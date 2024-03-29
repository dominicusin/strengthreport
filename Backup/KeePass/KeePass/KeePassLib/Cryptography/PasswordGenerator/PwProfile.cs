/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2008 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Diagnostics;

using KeePassLib.Security;

namespace KeePassLib.Cryptography.PasswordGenerator
{
	/// <summary>
	/// Type of the password generator. Different types like generators
	/// based on given patterns, based on character sets, etc. are
	/// available.
	/// </summary>
	public enum PasswordGeneratorType
	{
		/// <summary>
		/// Generator based on character spaces/sets, i.e. groups
		/// of characters like lower-case, upper-case or numeric characters.
		/// </summary>
		CharSet = 0,

		/// <summary>
		/// Password generation based on a pattern. The user has provided
		/// a pattern, which describes how the generated password has to
		/// look like.
		/// </summary>
		Pattern = 1
	}

	public sealed class PwProfile
	{
		public PwProfile()
		{
		}

		private string m_strName = string.Empty;
		public string Name
		{
			get { return m_strName; }
			set { m_strName = value; }
		}

		private PasswordGeneratorType m_type = PasswordGeneratorType.CharSet;
		public PasswordGeneratorType GeneratorType
		{
			get { return m_type; }
			set { m_type = value; }
		}

		private bool m_bUserEntropy = false;
		public bool CollectUserEntropy
		{
			get { return m_bUserEntropy; }
			set { m_bUserEntropy = value; }
		}

		private uint m_uLength = 20;
		public uint Length
		{
			get { return m_uLength; }
			set { m_uLength = value; }
		}

		private PwCharSet m_pwCharSet = new PwCharSet(PwCharSet.UpperCase +
			PwCharSet.LowerCase + PwCharSet.Digits);
		[XmlIgnore]
		public PwCharSet CharSet
		{
			get { return m_pwCharSet; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_pwCharSet = value;
			}
		}

		private string m_strCharSetRanges = string.Empty;
		public string CharSetRanges
		{
			get { this.UpdateCharSet(true); return m_strCharSetRanges; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strCharSetRanges = value;
				this.UpdateCharSet(false);
			}
		}

		private string m_strCharSetAdditional = string.Empty;
		public string CharSetAdditional
		{
			get { this.UpdateCharSet(true); return m_strCharSetAdditional; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strCharSetAdditional = value;
				this.UpdateCharSet(false);
			}
		}

		private string m_strPattern = string.Empty;
		public string Pattern
		{
			get { return m_strPattern; }
			set { m_strPattern = value; }
		}

		private bool m_bPatternPermute = false;
		public bool PatternPermutePassword
		{
			get { return m_bPatternPermute; }
			set { m_bPatternPermute = value; }
		}

		private bool m_bNoLookAlike = false;
		public bool ExcludeLookAlike
		{
			get { return m_bNoLookAlike; }
			set { m_bNoLookAlike = value; }
		}

		private bool m_bNoRepeat = false;
		public bool NoRepeatingCharacters
		{
			get { return m_bNoRepeat; }
			set { m_bNoRepeat = value; }
		}

		private string m_strExclude = string.Empty;
		public string ExcludeCharacters
		{
			get { return m_strExclude; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_strExclude = value;
			}
		}

		private void UpdateCharSet(bool bSetXml)
		{
			if(bSetXml)
			{
				PwCharSet pcs = new PwCharSet(m_pwCharSet.ToString());
				m_strCharSetRanges = pcs.PackAndRemoveCharRanges();
				m_strCharSetAdditional = pcs.ToString();
			}
			else
			{
				PwCharSet pcs = new PwCharSet(m_strCharSetAdditional);
				pcs.UnpackCharRanges(m_strCharSetRanges);
				m_pwCharSet = pcs;
			}
		}

		public static PwProfile DeriveFromPassword(ProtectedString psPassword)
		{
			PwProfile pp = new PwProfile();

			Debug.Assert(psPassword != null); if(psPassword == null) return pp;

			PwCharSet pcs = pp.CharSet;

			byte[] pbUTF8 = psPassword.ReadUtf8();
			char[] vChars = Encoding.UTF8.GetChars(pbUTF8);

			pp.GeneratorType = PasswordGeneratorType.CharSet;
			pp.Length = (uint)vChars.Length;

			foreach(char ch in vChars)
			{
				if((ch >= 'A') && (ch <= 'Z')) pcs.Add(PwCharSet.UpperCase);
				else if((ch >= 'a') && (ch <= 'z')) pcs.Add(PwCharSet.LowerCase);
				else if((ch >= '0') && (ch <= '9')) pcs.Add(PwCharSet.Digits);
				else if((@"!#$%&'*+,./:;=?@^").IndexOf(ch) >= 0) pcs.Add(pcs.SpecialChars);
				else if(ch == ' ') pcs.Add(' ');
				else if(ch == '-') pcs.Add('-');
				else if(ch == '_') pcs.Add('_');
				else if(ch == '\"') pcs.Add(pcs.SpecialChars);
				else if(ch == '\\') pcs.Add(pcs.SpecialChars);
				else if((@"()[]{}<>").IndexOf(ch) >= 0) pcs.Add(PwCharSet.Brackets);
				else if((ch >= '~') && (ch <= 255)) pcs.Add(pcs.HighAnsiChars);
				else pcs.Add(ch);
			}

			Array.Clear(vChars, 0, vChars.Length);
			Array.Clear(pbUTF8, 0, pbUTF8.Length);

			return pp;
		}

		public bool HasSecurityReducingOption()
		{
			return (m_bNoLookAlike || m_bNoRepeat || (m_strExclude.Length > 0));
		}
	}
}
