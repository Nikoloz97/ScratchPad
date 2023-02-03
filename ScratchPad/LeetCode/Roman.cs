using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    public class Roman
    {
        public int RomanToInt(string romanVal)
        {
            // Instantiate value int
            // Loop through string
            // Create conditionals (V after I = 4, etc.)
            // Else, char -> values
            // return value int

            int romanNum = 0;

            for (int i = 0; i < romanVal.Length; i++)
            {
                char current = romanVal[i];

                // If we're at the last value, convert char -> int as is
                if (current == romanVal.Length - 1)
                {
                    if (current == 'I')
                    {
                        romanNum++;

                    }

                    if (current == 'V')
                    {
                        romanNum += 5;
                    }

                    if (current == 'X')
                    {
                        romanNum += 10;
                    }

                    if (current == 'L')
                    {
                        romanNum += 50;
                    }

                    if (current == 'C')
                    {
                        romanNum += 100;
                    }

                    if (current == 'D')
                    {
                        romanNum += 500;
                    }

                    if (current == 'M')
                    {
                        romanNum += 10000;
                    }

                    return romanNum;

                }


                char next = romanVal[i + 1];


                if (current == 'I' || current == 'X' || current == 'C')
                {
                    if (current == 'I')
                    {
                        if (next != 'V' && next != 'X')
                        {
                            romanNum++;

                        }
                        else if (next == 'V')
                        {
                            romanNum += 4;

                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }
                            
                        }
                        else if (next == 'X')
                        {
                            romanNum += 9;
                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }
                        }
                    }
                    if (current == 'X')
                    {
                        if (next != 'L' && next != 'C')
                        {
                            romanNum += 10;
                        }
                        if (next == 'L')
                        {
                            romanNum += 40;
                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }

                        }

                        if (next == 'C')
                        {
                            romanNum += 90;
                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }

                        }

                    }
                    if (current == 'C')
                    {
                        if (next != 'D' && next != 'M')
                        {
                            romanNum += 100;
                        }
                        if (next == 'D')
                        {
                            romanNum += 400;
                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }
                        }
                        if (next == 'M')
                        {
                            romanNum += 900;
                            if (current != romanVal.Length - 2)
                            {
                                i++;
                            }
                            else
                            {
                                return romanNum;
                            }
                        }

                    }
                }

                else if (current == 'V')
                {
                    romanNum += 5;
                    
                }

                else if (current == 'L')
                {
                    romanNum += 50;
                }

                else if (current == 'D')
                {
                    romanNum += 500;

                }

                else if (current == 'M')
                {
                    romanNum += 1000;
                }


            }

            return romanNum;


        }

    }
}
