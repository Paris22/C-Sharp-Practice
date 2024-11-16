using System;

namespace ThreeInRowTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesInRowNumber = 3;
            int imagesInAlbumNumber = 52;
            int filledRows;
            int excessiveImages;

            filledRows = imagesInAlbumNumber / imagesInRowNumber;
            excessiveImages = imagesInAlbumNumber % imagesInRowNumber;

            Console.WriteLine($"Полностью заполненных рядов в альбоме: {filledRows}");
            Console.WriteLine($"Картинок сверх меры: {excessiveImages}");
        }
    }
}
