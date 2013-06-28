using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyHelpers
{
    class StringHelper
    {
        //*************************************************************************************
        //GetStringStats() Provides information on the characters which are in a string.
        //*************************************************************************************
        public static string GetStringStats(string sString)
        {
            string sResults = string.Empty;
            char[] CharArr = sString.ToCharArray();

            //int iCharCode = 0;
            int iTotalLines = 0;
            int iTotalCharacters = 0;
            int iCurrentLine = 0;
            int iCurrentLineLength = 0;
            int iLongestLine = 0;
            int iLongestLineChars = 0;
            int iStandardEnglish = 0;
            int iNull = 0;
            int iTab = 0;
            int iCr = 0;
            int iLF = 0;
            int iLowerCaseAlpha = 0;
            int iUpperCaseAlpha = 0;
            int iNumeric = 0;
            int iAbove255 = 0;
            int iAbove127 = 0;
            int iControlCharacters = 0;
            char xChar = ' ';
            long ixChar = 0;
            iTotalCharacters = sString.Length;
            for (int iCount = 0; iCount < sString.Length; iCount++)
            {
                xChar = CharArr[iCount];
                iCurrentLineLength++;
                if (xChar == '\n' || xChar == '\r')
                {
                    if (xChar == '\n')
                    {
                        iCurrentLine++;
                        iTotalLines++;
                    }
                    iCurrentLineLength = 0;
                }
                if (iCurrentLineLength > iLongestLineChars)
                {
                    iLongestLineChars = iCurrentLineLength;
                    iLongestLine = iCurrentLine;
                }
                ixChar = (int)xChar;
                if (xChar >= 'a' && xChar <= 'z') iLowerCaseAlpha++;
                if (xChar >= 'A' && xChar <= 'Z') iUpperCaseAlpha++;
                if (xChar >= '0' && xChar <= '9') iNumeric++;
                if (ixChar > 255) iAbove255++;
                if (ixChar > 127) iAbove127++;
                if (ixChar <= 31) iControlCharacters++;
                if (ixChar > 31 & ixChar < 127 || xChar == '\r' || xChar == '\n' || xChar == '\t')
                {
                    iStandardEnglish++;
                }
                if (xChar == '\0') iNull++;
                if (xChar == '\t') iTab++;
                if (xChar == '\r') iCr++;
                if (xChar == '\n') iLF++;
            }
            sResults += " Total Lines: " + iTotalLines.ToString() + " ";
            sResults += "Total Characters: " + iTotalCharacters.ToString() + " ";
            sResults += "Longest Line is " + iLongestLine.ToString() + " having " + iLongestLineChars.ToString() + " characters\r\n";
            sResults += "\r\n";
            sResults += " Characters:\r\n";
            sResults += string.Format(" {0} In Normal English Range - letters, numbers, symbols and Cr/Lf/Tab (31-126 dec range+ 13/10/9 dec) \r\n", iStandardEnglish.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Tab(09 hex)\r\n", iTab.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Cr (0D hex)\r\n", iCr.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Lf (0A hex)\r\n", iLF.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Control Characters (Range 0-31 dec/0-1F Hex)\r\n", iControlCharacters.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Above 127 dec range\r\n", iAbove255.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Above 255 dec range\r\n", iAbove127.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Null (00 hex)\r\n", iNull.ToString().PadLeft(6, ' '));

            sResults += string.Format(" {0} Lower Case\r\n", iLowerCaseAlpha.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Upper Case\r\n", iUpperCaseAlpha.ToString().PadLeft(6, ' '));
            sResults += string.Format(" {0} Numeric\r\n", iNumeric.ToString().PadLeft(6, ' '));
            sResults += "\r\n";

            return sResults;
        }

        //****************************************************************
        // DumpString() Will dump out the string in a Hex Dump.
        //****************************************************************
        public static string DumpString(string sString)
        {
            string sResults = string.Empty;
            char[] CharA = sString.ToCharArray();
            string sChar = " ";
            //int iCharCode = 0;
            //string sHex = "";
            string sLeft = "";
            string sRight = "";
            int iLine = 0;
            sResults = "000000 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF\r\n";
            sResults += "------+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+-----------------\r\n";
            int iChar = 0;
            for (int iCount = 0; iCount < sString.Length; iCount++)
            {
                char x = CharA[iCount];

                iChar = x;
                //if (char.IsControl((char)iValue))
                //{
                //    sText += " ";

                //}
                //else
                //{
                //    sText += string.Format("{0}", (char)iValue).PadLeft(1, ' ');
                //}

                if (char.IsControl((char)iChar))
                    sChar = " ";
                else
                    sChar = CharA[iCount].ToString();

                //if ((CharA[iCount] != '\n') &&
                //(CharA[iCount] != '\r') &&
                //(CharA[iCount] != '\0') &&
                //(CharA[iCount] != '\t'))
                //{
                //    sChar = CharA[iCount].ToString();
                //}
                //else
                //{
                //    sChar = " ";
                //}
                //iCharCode = Convert.ToInt32(CharA[iCount]);
                //sHex = String.Format("{0:X}", iCharCode);

                //sHex = String.Format("{0:X}", iChar);
                //sHex = sHex.PadLeft(2, '0');
                //sLeft += sHex + " ";

                sLeft += string.Format("{0000:X}", iChar).PadLeft(2, '0') + " ";
                sRight += sChar;
                //sResults += "" + sHex + " " + sChar + " " ;
                if (iCount % 16 == 15)
                {
                    sResults += String.Format("{0:X}", iLine).PadLeft(6, '0') + " " + sLeft + " " + sRight + "\r\n";
                    sLeft = "";
                    sRight = "";
                    iLine++;
                }
            }
            if (sLeft.Length != 0)
            {
                sResults += String.Format("{0:X}", iLine).PadLeft(6, '0') + " ";
                sResults += sLeft.PadRight(48, ' ') + " " + sRight + "\r\n";
            }
            sResults = sResults.TrimEnd();
            sResults += "\r\n";
            return sResults;
        }
        //****************************************************************************************
        // CompareStrings() will compare two different strings and tell you about differences...
        //****************************************************************************************
        public static string CompareStrings(string StringA, string StringB)
        {
            string sResults = string.Empty;
            int iComp = 0;
            //int iLength = 0;
            //StringA = txtFirstString.Text;
            //StringB = txtSecondString.Text;
            sResults += "First String Length: " + StringA.Length.ToString();
            sResults += " ";
            sResults += "Second String Length: " + StringB.Length.ToString();
            sResults += "\r\n";
            iComp = StringA.CompareTo(StringB);
            if (iComp < 0)
                sResults += "Value of First String is LESS THAN (<) Second String.\r\n";
            if (iComp == 0)
                sResults += "Value of First String is EQUAL TO (=) Second String.\r\n";
            if (iComp > 0)
                sResults += "Value of First String is GREATER THAN (>) Second String.\r\n";

            Boolean bResultFound = false;
            char[] CharA = StringA.ToCharArray();
            char[] CharB = StringB.ToCharArray();
            string sLineA = "";
            string sLineB = "";
            int iLineCount = 1;
            int iCharInLineCount = 1;
            int iLongestLineCharCount = 0;
            int iLongestLineAtLine = 0;
            // Value of First String is LESS THAN (<) Second String or the strings are equal...
            if (StringA.Length <= StringB.Length)
            {
                sResults += "\r\n*** First String VS Second String ***\r\n";
                for (int iCount = 0; iCount < StringA.Length; iCount++)
                {

                    if (CharA[iCount] != '\n' && CharA[iCount] != '\r')
                    {
                        sLineA += CharA[iCount].ToString();

                    }
                    if (CharB[iCount] != '\n' && CharB[iCount] != '\r')
                    {

                        sLineB += CharB[iCount].ToString();
                    }
                    iCharInLineCount++;
                    if (CharA[iCount] != CharB[iCount])
                    {
                        if (bResultFound == false)
                        {
                            sResults += "Found difference at string position: " + (int)(iCount + 1);
                            sResults += " ...Hex: " + String.Format("{0:X6}", (iCount / 16)) + " + " + String.Format("{0:X2}", (iCount % 16));
                            sResults += "";
                            sResults += "\r\n";
                            sResults += " Line: '" + iLineCount.ToString() + "' ";
                            sResults += " Char: '" + sLineA.Length.ToString() + "' \r\n\r\n";
                            sResults += " First String Char: '" + CharA[iCount].ToString() + "' ";
                            sResults += " Second String Char: '" + CharB[iCount].ToString() + "' \r\n";
                            sResults += " Start of First String: '" + sLineA + "' \r\n";
                            sResults += " Start of Second String: '" + sLineB + "' \r\n";
                            //sResults += " Character pos in stream: '" + iCount.ToString() + "' \r\n";
                            sResults += "\r\n";
                            bResultFound = true;
                        }
                    }
                    if (CharA[iCount] == '\n' || CharA[iCount] == '\r')
                    {
                        sLineA = "";
                        sLineB = "";
                        if (CharA[iCount] == '\n')
                        {
                            iLineCount++;
                            iCharInLineCount = 1;
                        }
                    }

                }
            }
            // Value of First String is GREATER THAN (>) Second String.
            if (StringA.Length > StringB.Length)
            {
                sResults += "\r\n*** Second String VS First String ***\r\n";
                for (int iCount = 0; iCount < StringB.Length; iCount++)
                {
                    if (CharA[iCount] != '\n' && CharA[iCount] != '\r')
                    {
                        sLineA += CharA[iCount].ToString();

                    }
                    if (CharB[iCount] != '\n' && CharB[iCount] != '\r')
                    {

                        sLineB += CharB[iCount].ToString();
                    }
                    iCharInLineCount++;
                    if (CharA[iCount] != CharB[iCount])
                    {
                        if (bResultFound == false)
                        {
                            sResults += "Found difference at position: " + (int)(iCount + 1);
                            sResults += " ...Hex: " + String.Format("{0:X6}", (iCount / 16)) + " + " + String.Format("{0:X2}", (iCount % 16));
                            sResults += " - Refer to Hex Dump below.";
                            sResults += "\r\n";
                            sResults += " Line: '" + iLineCount.ToString() + "' ";
                            sResults += " Char: '" + sLineA.Length.ToString() + "' \r\n";
                            sResults += " First String Char: '" + CharA[iCount].ToString() + "' ";
                            sResults += " Second String Char: '" + CharB[iCount].ToString() + "' \r\n";
                            sResults += " Start of First String: '" + sLineA + "' \r\n";
                            sResults += " Start of Second String: '" + sLineB + "' \r\n";

                            sResults += "\r\n";
                            bResultFound = true;
                        }
                    }
                    if (CharB[iCount] == '\n' || CharB[iCount] == '\r')
                    {
                        sLineA = "";
                        sLineB = "";
                        if (CharB[iCount] == '\n')
                        {
                            iLineCount++;
                            iCharInLineCount = 1;
                        }
                    }
                    if (iCharInLineCount > iLongestLineCharCount)
                    {
                        iLongestLineCharCount = iCharInLineCount;
                        iLongestLineAtLine = iLineCount;
                    }
                }
            }
            if (bResultFound == false)
            {
                if (StringA.Length > StringB.Length)
                {
                    sResults += "The difference is in what is in first string and not in second string... \r\n";
                    sResults += " * The first string is longer by " + String.Format("{0}", (StringA.Length - StringB.Length)) + " characters.\r\n";
                }
                if (StringA.Length < StringB.Length)
                {
                    sResults += "The difference is in what is in second string and not in first string... \r\n";
                    sResults += " * The second string is longer by " + String.Format("{0}", (StringB.Length - StringA.Length)) + " characters.\r\n";
                }

            }
            return sResults;
        }



        public static bool HexDumpFromFile(string sFile, ref string sDump)
        {
            bool bRet = false;

            int iItemsPerLine = 16;

            StringBuilder oSB = new StringBuilder();
            BinaryReader b = null;
            string sHex = string.Empty;
            int iValue = 0;
            int iItem = 0;
            int iReadSize = sizeof(byte);
            string sText = string.Empty;

            string sHeader1 = "       00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF\r\n";
            string sHeader2 = "------+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+-----------------\r\n";


            string path = sFile.Trim();
            if (File.Exists(path))
            {

                try
                {
                    oSB.Append(sHeader1);
                    oSB.Append(sHeader2);

                    b = new BinaryReader(File.Open(path, FileMode.Open));


                    int pos = 0;

                    int length = (int)b.BaseStream.Length;
                    while (pos < length)
                    {
                        //iValue = b.ReadInt32();
                        //iValue = b.ReadChar();
                        iValue = b.ReadByte();
                        iItem += 1;

                        if (char.IsControl((char)iValue))
                        {
                            sText += " ";

                        }
                        else
                        {
                            sText += string.Format("{0}", (char)iValue).PadLeft(1, ' ');
                        }

                        // Start of Line - Add position
                        if (iItem == 1)
                        {
                            oSB.Append(string.Format("{0000:X}", pos).PadLeft(4, '0'));
                            oSB.Append("  ");
                        }

                        if (iItem <= iItemsPerLine)
                        {
                            oSB.Append(" ");
                            sHex = string.Format("{00:X}", iValue).PadLeft(2, '0');
                            oSB.Append(sHex);

                            // Text Representation of hex bits.
                            if (iItem == iItemsPerLine)
                            {

                                oSB.Append("  " + sText); // Add text representation of hex.
                                sText = string.Empty;
                                sHex = string.Format("\r\n");
                                oSB.Append(sHex);

                                sHex = string.Empty;
                                iItem = 0;
                            }
                        }


                        pos += iReadSize;  // Point to next.
                    }

                    b.Close();
                    b = null;
                    sDump = oSB.ToString();
                    bRet = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Reading File");
                    bRet = false;
                }



            }

            return bRet;

        }

        public static string HexDumpFromByteArray(byte[] baArrayToDump)
        {
            string sRet = string.Empty;

            int iItemsPerLine = 16;

            StringBuilder oSB = new StringBuilder();

            string sHex = string.Empty;
            int iValue = 0;
            int iItem = 0;

            string sText = string.Empty;

            string sHeader1 = "       00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF\r\n";
            string sHeader2 = "------+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+-----------------\r\n";


            oSB.Append(sHeader1);
            oSB.Append(sHeader2);
            int pos = 0;
            foreach (byte oByte in baArrayToDump)
            {
                iValue = oByte;
                iItem += 1;

                if (char.IsControl((char)iValue))
                {
                    sText += " ";

                }
                else
                {
                    sText += string.Format("{0}", (char)iValue).PadLeft(1, ' ');
                }

                // Start of Line - Add position
                if (iItem == 1)
                {
                    oSB.Append(string.Format("{0000:X}", pos).PadLeft(4, '0'));
                    oSB.Append("  ");
                }

                if (iItem <= iItemsPerLine)
                {
                    oSB.Append(" ");
                    sHex = string.Format("{00:X}", iValue).PadLeft(2, '0');
                    oSB.Append(sHex);

                    // Text Representation of hex bits.
                    if (iItem == iItemsPerLine)
                    {

                        oSB.Append("  " + sText); // Add text representation of hex.
                        sText = string.Empty;
                        sHex = string.Format("\r\n");
                        oSB.Append(sHex);

                        sHex = string.Empty;
                        iItem = 0;
                    }

                }

                pos++;
            }
            sRet = oSB.ToString();
            return sRet;

        }


        public static string HexStringFromByteArray(byte[] baArrayToDump)
        {
            string sRet = string.Empty;

            //int iItemsPerLine = 16;

            StringBuilder oSB = new StringBuilder();

            string sHex = string.Empty;
            int iValue = 0;
            int iItem = 0;

            string sText = string.Empty;


            //int pos = 0;
            foreach (byte oByte in baArrayToDump)
            {
                iValue = oByte;
                iItem += 1;

                if (char.IsControl((char)iValue))
                {
                    sText += " ";

                }
                else
                {
                    sText += string.Format("{0}", (char)iValue).PadLeft(1, ' ');
                }

                //// Start of Line - Add position
                //if (iItem == 1)
                //{
                //    oSB.Append(string.Format("{0000:X}", pos).PadLeft(4, '0'));
                //    oSB.Append("  ");
                //}

                //if (iItem <= iItemsPerLine)
                //{
                oSB.Append(" ");
                sHex = string.Format("{00:X}", iValue).PadLeft(2, '0');
                oSB.Append(sHex);

                //// Text Representation of hex bits.
                //if (iItem == iItemsPerLine)
                //{

                //    oSB.Append("  " + sText); // Add text representation of hex.
                //    sText = string.Empty;
                //    sHex = string.Format("\r\n");
                //    oSB.Append(sHex);

                //    sHex = string.Empty;
                //    iItem = 0;
                //}

                //}
            }
            sRet = oSB.ToString();
            return sRet;

        }


        // Note: Helping calls:
        //
        //string sItem = Enum.GetName(typeof(DayOfTheWeek), DayOfTheWeek.Monday); // String for name
        //string = Enum.GetName(typeof(DayOfTheWeek), 3));  // Third Instnace name of enumeration
        //oDayOfTheWeek = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), "Monday"); // Convert from string to enumerated value


    }
}
