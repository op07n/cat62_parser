﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT62_Service.CAT62 {
  public static class Encode6Bit {
    public static Dictionary<int, char> Char = new Dictionary<int, char> {
      {1, 'A' }, {2, 'B' }, {3, 'C' }, {4, 'D' }, {5, 'E' }, {6, 'F' }, {7, 'G' }, {8, 'H' }, {9, 'I' }, {10, 'J' },
      {11, 'K'}, {12, 'L'}, {13, 'M'}, {14, 'N'}, {15, 'O'}, {16, 'P'}, {17, 'Q'}, {18, 'R'}, {19, 'S'}, {20, 'T'},
      {21, 'U'}, {22, 'V'}, {23, 'W'}, {24, 'X'}, {25, 'Y'}, {26, 'Z'}, {27, '-'}, {28, '-'}, {29, '-'}, {30, '-'},
      {32, ' ' },
      {48, '0'}, {49, '1'}, {50, '2'}, {51, '3'}, {52, '4'}, {53, '5'}, {54, '6'}, {55, '7'}, {56, '8'}, {57, '9'}, {58, '0'}
    };
  }
}
