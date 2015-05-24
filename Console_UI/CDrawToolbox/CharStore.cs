namespace CCoreImpl
{
    public static class CharStore
    {

        public static class Characters
        {
            public static char BlankSpaceChar = ' ';
        }

        public static class Borders
        {
            public static class SingleBorder
            {
                public static char LeftTopCornerSingleBorderChar = '┌';
                public static char RightTopCornerSingleBorderChar = '┐';
                public static char LeftBottomCornerSingleBorderChar = '└';
                public static char RightBottomCornerSingleBorderChar = '┘';

                public static char LeftJunctionSingleBorderChar = '├';
                public static char RightJunctionSingleBorderChar = '┤';
                public static char TopJunctionSingleBorderChar = '┬';
                public static char BottomJunctionSingleBorderChar = '┴';

                public static char OmniJunctionSingleBorderChar = '┼';

                public static char HorizontalSingleChar = '─';
                public static char VerticalSingleChar = '│';
            }

            public static class DoubleBorder
            {
                public static char LeftTopCornerDoubleBorderChar = '╔';
                public static char RightTopCornerDoubleBorderChar = '╗';
                public static char LeftBottomCornerDoubleBorderChar = '╚';
                public static char RightBottomCornerDoubleBorderChar = '╝';

                public static char LeftJunctionDoubleBorderChar = '╠';
                public static char RightJunctionDoubleBorderChar = '╣';
                public static char TopJunctionDoubleBorderChar = '╦';
                public static char BottomJunctionDoubleBorderChar = '╩';
                public static char OmniJunctionDoubleBorderChar = '╬';

                public static char HorizontalDoubleChar = '═';
                public static char VerticalDoubleChar = '║';
            }
        }
       
    }
}
