using Microsoft.EntityFrameworkCore.Migrations;

namespace shop.Migrations
{
    public partial class generat_data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 1, "description for advertising number 1", 100, 1, "title for advertasing N 1" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { "description for advertising number 2", 150, 2, "title for advertasing N 2" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 3, "description for advertising number 3", 200, 3, "title for advertasing N 3" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 4, "description for advertising number 4", 250, 4, "title for advertasing N 4" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 5, "description for advertising number 5", 300, 5, "title for advertasing N 5" });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "AdId", "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 498, 3, "description for advertising number 498", 24950, 81, "title for advertasing N 498" },
                    { 343, 2, "description for advertising number 343", 17200, 65, "title for advertasing N 343" },
                    { 342, 1, "description for advertising number 342", 17150, 64, "title for advertasing N 342" },
                    { 341, 11, "description for advertising number 341", 17100, 63, "title for advertasing N 341" },
                    { 340, 10, "description for advertising number 340", 17050, 62, "title for advertasing N 340" },
                    { 339, 9, "description for advertising number 339", 17000, 61, "title for advertasing N 339" },
                    { 338, 8, "description for advertising number 338", 16950, 60, "title for advertasing N 338" },
                    { 337, 7, "description for advertising number 337", 16900, 59, "title for advertasing N 337" },
                    { 336, 6, "description for advertising number 336", 16850, 58, "title for advertasing N 336" },
                    { 335, 5, "description for advertising number 335", 16800, 57, "title for advertasing N 335" },
                    { 334, 4, "description for advertising number 334", 16750, 56, "title for advertasing N 334" },
                    { 333, 3, "description for advertising number 333", 16700, 55, "title for advertasing N 333" },
                    { 332, 2, "description for advertising number 332", 16650, 54, "title for advertasing N 332" },
                    { 344, 3, "description for advertising number 344", 17250, 66, "title for advertasing N 344" },
                    { 331, 1, "description for advertising number 331", 16600, 53, "title for advertasing N 331" },
                    { 329, 10, "description for advertising number 329", 16500, 51, "title for advertasing N 329" },
                    { 328, 9, "description for advertising number 328", 16450, 50, "title for advertasing N 328" },
                    { 327, 8, "description for advertising number 327", 16400, 49, "title for advertasing N 327" },
                    { 326, 7, "description for advertising number 326", 16350, 48, "title for advertasing N 326" },
                    { 325, 6, "description for advertising number 325", 16300, 47, "title for advertasing N 325" },
                    { 324, 5, "description for advertising number 324", 16250, 46, "title for advertasing N 324" },
                    { 323, 4, "description for advertising number 323", 16200, 45, "title for advertasing N 323" },
                    { 322, 3, "description for advertising number 322", 16150, 44, "title for advertasing N 322" },
                    { 321, 2, "description for advertising number 321", 16100, 43, "title for advertasing N 321" },
                    { 320, 1, "description for advertising number 320", 16050, 42, "title for advertasing N 320" },
                    { 319, 11, "description for advertising number 319", 16000, 41, "title for advertasing N 319" },
                    { 318, 10, "description for advertising number 318", 15950, 40, "title for advertasing N 318" },
                    { 330, 11, "description for advertising number 330", 16550, 52, "title for advertasing N 330" },
                    { 345, 4, "description for advertising number 345", 17300, 67, "title for advertasing N 345" },
                    { 346, 5, "description for advertising number 346", 17350, 68, "title for advertasing N 346" },
                    { 347, 6, "description for advertising number 347", 17400, 69, "title for advertasing N 347" },
                    { 374, 11, "description for advertising number 374", 18750, 96, "title for advertasing N 374" },
                    { 373, 10, "description for advertising number 373", 18700, 95, "title for advertasing N 373" },
                    { 372, 9, "description for advertising number 372", 18650, 94, "title for advertasing N 372" },
                    { 371, 8, "description for advertising number 371", 18600, 93, "title for advertasing N 371" },
                    { 370, 7, "description for advertising number 370", 18550, 92, "title for advertasing N 370" },
                    { 369, 6, "description for advertising number 369", 18500, 91, "title for advertasing N 369" },
                    { 368, 5, "description for advertising number 368", 18450, 90, "title for advertasing N 368" },
                    { 367, 4, "description for advertising number 367", 18400, 89, "title for advertasing N 367" },
                    { 366, 3, "description for advertising number 366", 18350, 88, "title for advertasing N 366" },
                    { 365, 2, "description for advertising number 365", 18300, 87, "title for advertasing N 365" },
                    { 364, 1, "description for advertising number 364", 18250, 86, "title for advertasing N 364" },
                    { 363, 11, "description for advertising number 363", 18200, 85, "title for advertasing N 363" },
                    { 362, 10, "description for advertising number 362", 18150, 84, "title for advertasing N 362" },
                    { 361, 9, "description for advertising number 361", 18100, 83, "title for advertasing N 361" },
                    { 360, 8, "description for advertising number 360", 18050, 82, "title for advertasing N 360" },
                    { 359, 7, "description for advertising number 359", 18000, 81, "title for advertasing N 359" },
                    { 358, 6, "description for advertising number 358", 17950, 80, "title for advertasing N 358" },
                    { 357, 5, "description for advertising number 357", 17900, 79, "title for advertasing N 357" },
                    { 356, 4, "description for advertising number 356", 17850, 78, "title for advertasing N 356" },
                    { 355, 3, "description for advertising number 355", 17800, 77, "title for advertasing N 355" },
                    { 354, 2, "description for advertising number 354", 17750, 76, "title for advertasing N 354" },
                    { 353, 1, "description for advertising number 353", 17700, 75, "title for advertasing N 353" },
                    { 352, 11, "description for advertising number 352", 17650, 74, "title for advertasing N 352" },
                    { 351, 10, "description for advertising number 351", 17600, 73, "title for advertasing N 351" },
                    { 350, 9, "description for advertising number 350", 17550, 72, "title for advertasing N 350" },
                    { 349, 8, "description for advertising number 349", 17500, 71, "title for advertasing N 349" },
                    { 348, 7, "description for advertising number 348", 17450, 70, "title for advertasing N 348" },
                    { 317, 9, "description for advertising number 317", 15900, 39, "title for advertasing N 317" },
                    { 375, 1, "description for advertising number 375", 18800, 97, "title for advertasing N 375" },
                    { 316, 8, "description for advertising number 316", 15850, 38, "title for advertasing N 316" },
                    { 314, 6, "description for advertising number 314", 15750, 36, "title for advertasing N 314" },
                    { 282, 7, "description for advertising number 282", 14150, 4, "title for advertasing N 282" },
                    { 281, 6, "description for advertising number 281", 14100, 3, "title for advertasing N 281" },
                    { 280, 5, "description for advertising number 280", 14050, 2, "title for advertasing N 280" },
                    { 279, 4, "description for advertising number 279", 14000, 1, "title for advertasing N 279" },
                    { 278, 3, "description for advertising number 278", 13950, 139, "title for advertasing N 278" },
                    { 277, 2, "description for advertising number 277", 13900, 138, "title for advertasing N 277" },
                    { 276, 1, "description for advertising number 276", 13850, 137, "title for advertasing N 276" },
                    { 275, 11, "description for advertising number 275", 13800, 136, "title for advertasing N 275" },
                    { 274, 10, "description for advertising number 274", 13750, 135, "title for advertasing N 274" },
                    { 273, 9, "description for advertising number 273", 13700, 134, "title for advertasing N 273" },
                    { 272, 8, "description for advertising number 272", 13650, 133, "title for advertasing N 272" },
                    { 271, 7, "description for advertising number 271", 13600, 132, "title for advertasing N 271" },
                    { 283, 8, "description for advertising number 283", 14200, 5, "title for advertasing N 283" },
                    { 270, 6, "description for advertising number 270", 13550, 131, "title for advertasing N 270" },
                    { 268, 4, "description for advertising number 268", 13450, 129, "title for advertasing N 268" },
                    { 267, 3, "description for advertising number 267", 13400, 128, "title for advertasing N 267" },
                    { 266, 2, "description for advertising number 266", 13350, 127, "title for advertasing N 266" },
                    { 265, 1, "description for advertising number 265", 13300, 126, "title for advertasing N 265" },
                    { 264, 11, "description for advertising number 264", 13250, 125, "title for advertasing N 264" },
                    { 263, 10, "description for advertising number 263", 13200, 124, "title for advertasing N 263" },
                    { 262, 9, "description for advertising number 262", 13150, 123, "title for advertasing N 262" },
                    { 261, 8, "description for advertising number 261", 13100, 122, "title for advertasing N 261" },
                    { 260, 7, "description for advertising number 260", 13050, 121, "title for advertasing N 260" },
                    { 259, 6, "description for advertising number 259", 13000, 120, "title for advertasing N 259" },
                    { 258, 5, "description for advertising number 258", 12950, 119, "title for advertasing N 258" },
                    { 257, 4, "description for advertising number 257", 12900, 118, "title for advertasing N 257" },
                    { 269, 5, "description for advertising number 269", 13500, 130, "title for advertasing N 269" },
                    { 284, 9, "description for advertising number 284", 14250, 6, "title for advertasing N 284" },
                    { 285, 10, "description for advertising number 285", 14300, 7, "title for advertasing N 285" },
                    { 286, 11, "description for advertising number 286", 14350, 8, "title for advertasing N 286" },
                    { 313, 5, "description for advertising number 313", 15700, 35, "title for advertasing N 313" },
                    { 312, 4, "description for advertising number 312", 15650, 34, "title for advertasing N 312" },
                    { 311, 3, "description for advertising number 311", 15600, 33, "title for advertasing N 311" },
                    { 310, 2, "description for advertising number 310", 15550, 32, "title for advertasing N 310" },
                    { 309, 1, "description for advertising number 309", 15500, 31, "title for advertasing N 309" },
                    { 308, 11, "description for advertising number 308", 15450, 30, "title for advertasing N 308" },
                    { 307, 10, "description for advertising number 307", 15400, 29, "title for advertasing N 307" },
                    { 306, 9, "description for advertising number 306", 15350, 28, "title for advertasing N 306" },
                    { 305, 8, "description for advertising number 305", 15300, 27, "title for advertasing N 305" },
                    { 304, 7, "description for advertising number 304", 15250, 26, "title for advertasing N 304" },
                    { 303, 6, "description for advertising number 303", 15200, 25, "title for advertasing N 303" },
                    { 302, 5, "description for advertising number 302", 15150, 24, "title for advertasing N 302" },
                    { 301, 4, "description for advertising number 301", 15100, 23, "title for advertasing N 301" },
                    { 300, 3, "description for advertising number 300", 15050, 22, "title for advertasing N 300" },
                    { 299, 2, "description for advertising number 299", 15000, 21, "title for advertasing N 299" },
                    { 298, 1, "description for advertising number 298", 14950, 20, "title for advertasing N 298" },
                    { 297, 11, "description for advertising number 297", 14900, 19, "title for advertasing N 297" },
                    { 296, 10, "description for advertising number 296", 14850, 18, "title for advertasing N 296" },
                    { 295, 9, "description for advertising number 295", 14800, 17, "title for advertasing N 295" },
                    { 294, 8, "description for advertising number 294", 14750, 16, "title for advertasing N 294" },
                    { 293, 7, "description for advertising number 293", 14700, 15, "title for advertasing N 293" },
                    { 292, 6, "description for advertising number 292", 14650, 14, "title for advertasing N 292" },
                    { 291, 5, "description for advertising number 291", 14600, 13, "title for advertasing N 291" },
                    { 290, 4, "description for advertising number 290", 14550, 12, "title for advertasing N 290" },
                    { 289, 3, "description for advertising number 289", 14500, 11, "title for advertasing N 289" },
                    { 288, 2, "description for advertising number 288", 14450, 10, "title for advertasing N 288" },
                    { 287, 1, "description for advertising number 287", 14400, 9, "title for advertasing N 287" },
                    { 315, 7, "description for advertising number 315", 15800, 37, "title for advertasing N 315" },
                    { 376, 2, "description for advertising number 376", 18850, 98, "title for advertasing N 376" },
                    { 377, 3, "description for advertising number 377", 18900, 99, "title for advertasing N 377" },
                    { 378, 4, "description for advertising number 378", 18950, 100, "title for advertasing N 378" },
                    { 466, 4, "description for advertising number 466", 23350, 49, "title for advertasing N 466" },
                    { 465, 3, "description for advertising number 465", 23300, 48, "title for advertasing N 465" },
                    { 464, 2, "description for advertising number 464", 23250, 47, "title for advertasing N 464" },
                    { 463, 1, "description for advertising number 463", 23200, 46, "title for advertasing N 463" },
                    { 462, 11, "description for advertising number 462", 23150, 45, "title for advertasing N 462" },
                    { 461, 10, "description for advertising number 461", 23100, 44, "title for advertasing N 461" },
                    { 460, 9, "description for advertising number 460", 23050, 43, "title for advertasing N 460" },
                    { 459, 8, "description for advertising number 459", 23000, 42, "title for advertasing N 459" },
                    { 458, 7, "description for advertising number 458", 22950, 41, "title for advertasing N 458" },
                    { 457, 6, "description for advertising number 457", 22900, 40, "title for advertasing N 457" },
                    { 456, 5, "description for advertising number 456", 22850, 39, "title for advertasing N 456" },
                    { 455, 4, "description for advertising number 455", 22800, 38, "title for advertasing N 455" },
                    { 467, 5, "description for advertising number 467", 23400, 50, "title for advertasing N 467" },
                    { 454, 3, "description for advertising number 454", 22750, 37, "title for advertasing N 454" },
                    { 452, 1, "description for advertising number 452", 22650, 35, "title for advertasing N 452" },
                    { 451, 11, "description for advertising number 451", 22600, 34, "title for advertasing N 451" },
                    { 450, 10, "description for advertising number 450", 22550, 33, "title for advertasing N 450" },
                    { 449, 9, "description for advertising number 449", 22500, 32, "title for advertasing N 449" },
                    { 448, 8, "description for advertising number 448", 22450, 31, "title for advertasing N 448" },
                    { 447, 7, "description for advertising number 447", 22400, 30, "title for advertasing N 447" },
                    { 446, 6, "description for advertising number 446", 22350, 29, "title for advertasing N 446" },
                    { 445, 5, "description for advertising number 445", 22300, 28, "title for advertasing N 445" },
                    { 444, 4, "description for advertising number 444", 22250, 27, "title for advertasing N 444" },
                    { 443, 3, "description for advertising number 443", 22200, 26, "title for advertasing N 443" },
                    { 442, 2, "description for advertising number 442", 22150, 25, "title for advertasing N 442" },
                    { 441, 1, "description for advertising number 441", 22100, 24, "title for advertasing N 441" },
                    { 453, 2, "description for advertising number 453", 22700, 36, "title for advertasing N 453" },
                    { 468, 6, "description for advertising number 468", 23450, 51, "title for advertasing N 468" },
                    { 469, 7, "description for advertising number 469", 23500, 52, "title for advertasing N 469" },
                    { 470, 8, "description for advertising number 470", 23550, 53, "title for advertasing N 470" },
                    { 497, 2, "description for advertising number 497", 24900, 80, "title for advertasing N 497" },
                    { 496, 1, "description for advertising number 496", 24850, 79, "title for advertasing N 496" },
                    { 495, 11, "description for advertising number 495", 24800, 78, "title for advertasing N 495" },
                    { 494, 10, "description for advertising number 494", 24750, 77, "title for advertasing N 494" },
                    { 493, 9, "description for advertising number 493", 24700, 76, "title for advertasing N 493" },
                    { 492, 8, "description for advertising number 492", 24650, 75, "title for advertasing N 492" },
                    { 491, 7, "description for advertising number 491", 24600, 74, "title for advertasing N 491" },
                    { 490, 6, "description for advertising number 490", 24550, 73, "title for advertasing N 490" },
                    { 489, 5, "description for advertising number 489", 24500, 72, "title for advertasing N 489" },
                    { 488, 4, "description for advertising number 488", 24450, 71, "title for advertasing N 488" },
                    { 487, 3, "description for advertising number 487", 24400, 70, "title for advertasing N 487" },
                    { 486, 2, "description for advertising number 486", 24350, 69, "title for advertasing N 486" },
                    { 485, 1, "description for advertising number 485", 24300, 68, "title for advertasing N 485" },
                    { 484, 11, "description for advertising number 484", 24250, 67, "title for advertasing N 484" },
                    { 483, 10, "description for advertising number 483", 24200, 66, "title for advertasing N 483" },
                    { 482, 9, "description for advertising number 482", 24150, 65, "title for advertasing N 482" },
                    { 481, 8, "description for advertising number 481", 24100, 64, "title for advertasing N 481" },
                    { 480, 7, "description for advertising number 480", 24050, 63, "title for advertasing N 480" },
                    { 479, 6, "description for advertising number 479", 24000, 62, "title for advertasing N 479" },
                    { 478, 5, "description for advertising number 478", 23950, 61, "title for advertasing N 478" },
                    { 477, 4, "description for advertising number 477", 23900, 60, "title for advertasing N 477" },
                    { 476, 3, "description for advertising number 476", 23850, 59, "title for advertasing N 476" },
                    { 475, 2, "description for advertising number 475", 23800, 58, "title for advertasing N 475" },
                    { 474, 1, "description for advertising number 474", 23750, 57, "title for advertasing N 474" },
                    { 473, 11, "description for advertising number 473", 23700, 56, "title for advertasing N 473" },
                    { 472, 10, "description for advertising number 472", 23650, 55, "title for advertasing N 472" },
                    { 471, 9, "description for advertising number 471", 23600, 54, "title for advertasing N 471" },
                    { 440, 11, "description for advertising number 440", 22050, 23, "title for advertasing N 440" },
                    { 439, 10, "description for advertising number 439", 22000, 22, "title for advertasing N 439" },
                    { 438, 9, "description for advertising number 438", 21950, 21, "title for advertasing N 438" },
                    { 437, 8, "description for advertising number 437", 21900, 20, "title for advertasing N 437" },
                    { 405, 9, "description for advertising number 405", 20300, 127, "title for advertasing N 405" },
                    { 404, 8, "description for advertising number 404", 20250, 126, "title for advertasing N 404" },
                    { 403, 7, "description for advertising number 403", 20200, 125, "title for advertasing N 403" },
                    { 402, 6, "description for advertising number 402", 20150, 124, "title for advertasing N 402" },
                    { 401, 5, "description for advertising number 401", 20100, 123, "title for advertasing N 401" },
                    { 400, 4, "description for advertising number 400", 20050, 122, "title for advertasing N 400" },
                    { 399, 3, "description for advertising number 399", 20000, 121, "title for advertasing N 399" },
                    { 398, 2, "description for advertising number 398", 19950, 120, "title for advertasing N 398" },
                    { 397, 1, "description for advertising number 397", 19900, 119, "title for advertasing N 397" },
                    { 396, 11, "description for advertising number 396", 19850, 118, "title for advertasing N 396" },
                    { 395, 10, "description for advertising number 395", 19800, 117, "title for advertasing N 395" },
                    { 394, 9, "description for advertising number 394", 19750, 116, "title for advertasing N 394" },
                    { 393, 8, "description for advertising number 393", 19700, 115, "title for advertasing N 393" },
                    { 392, 7, "description for advertising number 392", 19650, 114, "title for advertasing N 392" },
                    { 391, 6, "description for advertising number 391", 19600, 113, "title for advertasing N 391" },
                    { 390, 5, "description for advertising number 390", 19550, 112, "title for advertasing N 390" },
                    { 389, 4, "description for advertising number 389", 19500, 111, "title for advertasing N 389" },
                    { 388, 3, "description for advertising number 388", 19450, 110, "title for advertasing N 388" },
                    { 387, 2, "description for advertising number 387", 19400, 109, "title for advertasing N 387" },
                    { 386, 1, "description for advertising number 386", 19350, 108, "title for advertasing N 386" },
                    { 385, 11, "description for advertising number 385", 19300, 107, "title for advertasing N 385" },
                    { 384, 10, "description for advertising number 384", 19250, 106, "title for advertasing N 384" },
                    { 383, 9, "description for advertising number 383", 19200, 105, "title for advertasing N 383" },
                    { 382, 8, "description for advertising number 382", 19150, 104, "title for advertasing N 382" },
                    { 381, 7, "description for advertising number 381", 19100, 103, "title for advertasing N 381" },
                    { 380, 6, "description for advertising number 380", 19050, 102, "title for advertasing N 380" },
                    { 256, 3, "description for advertising number 256", 12850, 117, "title for advertasing N 256" },
                    { 406, 10, "description for advertising number 406", 20350, 128, "title for advertasing N 406" },
                    { 499, 4, "description for advertising number 499", 25000, 82, "title for advertasing N 499" },
                    { 407, 11, "description for advertising number 407", 20400, 129, "title for advertasing N 407" },
                    { 409, 2, "description for advertising number 409", 20500, 131, "title for advertasing N 409" },
                    { 436, 7, "description for advertising number 436", 21850, 19, "title for advertasing N 436" },
                    { 435, 6, "description for advertising number 435", 21800, 18, "title for advertasing N 435" },
                    { 434, 5, "description for advertising number 434", 21750, 17, "title for advertasing N 434" },
                    { 433, 4, "description for advertising number 433", 21700, 16, "title for advertasing N 433" },
                    { 432, 3, "description for advertising number 432", 21650, 15, "title for advertasing N 432" },
                    { 431, 2, "description for advertising number 431", 21600, 14, "title for advertasing N 431" },
                    { 430, 1, "description for advertising number 430", 21550, 13, "title for advertasing N 430" },
                    { 429, 11, "description for advertising number 429", 21500, 12, "title for advertasing N 429" },
                    { 428, 10, "description for advertising number 428", 21450, 11, "title for advertasing N 428" },
                    { 427, 9, "description for advertising number 427", 21400, 10, "title for advertasing N 427" },
                    { 426, 8, "description for advertising number 426", 21350, 9, "title for advertasing N 426" },
                    { 425, 7, "description for advertising number 425", 21300, 8, "title for advertasing N 425" },
                    { 424, 6, "description for advertising number 424", 21250, 7, "title for advertasing N 424" },
                    { 423, 5, "description for advertising number 423", 21200, 6, "title for advertasing N 423" },
                    { 422, 4, "description for advertising number 422", 21150, 5, "title for advertasing N 422" },
                    { 421, 3, "description for advertising number 421", 21100, 4, "title for advertasing N 421" },
                    { 420, 2, "description for advertising number 420", 21050, 3, "title for advertasing N 420" },
                    { 419, 1, "description for advertising number 419", 21000, 2, "title for advertasing N 419" },
                    { 418, 11, "description for advertising number 418", 20950, 1, "title for advertasing N 418" },
                    { 417, 10, "description for advertising number 417", 20900, 139, "title for advertasing N 417" },
                    { 416, 9, "description for advertising number 416", 20850, 138, "title for advertasing N 416" },
                    { 415, 8, "description for advertising number 415", 20800, 137, "title for advertasing N 415" },
                    { 414, 7, "description for advertising number 414", 20750, 136, "title for advertasing N 414" },
                    { 413, 6, "description for advertising number 413", 20700, 135, "title for advertasing N 413" },
                    { 412, 5, "description for advertising number 412", 20650, 134, "title for advertasing N 412" },
                    { 411, 4, "description for advertising number 411", 20600, 133, "title for advertasing N 411" },
                    { 410, 3, "description for advertising number 410", 20550, 132, "title for advertasing N 410" },
                    { 408, 1, "description for advertising number 408", 20450, 130, "title for advertasing N 408" },
                    { 379, 5, "description for advertising number 379", 19000, 101, "title for advertasing N 379" },
                    { 255, 2, "description for advertising number 255", 12800, 116, "title for advertasing N 255" },
                    { 253, 11, "description for advertising number 253", 12700, 114, "title for advertasing N 253" },
                    { 96, 8, "description for advertising number 96", 4850, 96, "title for advertasing N 96" },
                    { 95, 7, "description for advertising number 95", 4800, 95, "title for advertasing N 95" },
                    { 94, 6, "description for advertising number 94", 4750, 94, "title for advertasing N 94" },
                    { 93, 5, "description for advertising number 93", 4700, 93, "title for advertasing N 93" },
                    { 92, 4, "description for advertising number 92", 4650, 92, "title for advertasing N 92" },
                    { 91, 3, "description for advertising number 91", 4600, 91, "title for advertasing N 91" },
                    { 90, 2, "description for advertising number 90", 4550, 90, "title for advertasing N 90" },
                    { 89, 1, "description for advertising number 89", 4500, 89, "title for advertasing N 89" },
                    { 88, 11, "description for advertising number 88", 4450, 88, "title for advertasing N 88" },
                    { 87, 10, "description for advertising number 87", 4400, 87, "title for advertasing N 87" },
                    { 86, 9, "description for advertising number 86", 4350, 86, "title for advertasing N 86" },
                    { 85, 8, "description for advertising number 85", 4300, 85, "title for advertasing N 85" },
                    { 84, 7, "description for advertising number 84", 4250, 84, "title for advertasing N 84" },
                    { 83, 6, "description for advertising number 83", 4200, 83, "title for advertasing N 83" },
                    { 82, 5, "description for advertising number 82", 4150, 82, "title for advertasing N 82" },
                    { 81, 4, "description for advertising number 81", 4100, 81, "title for advertasing N 81" },
                    { 80, 3, "description for advertising number 80", 4050, 80, "title for advertasing N 80" },
                    { 79, 2, "description for advertising number 79", 4000, 79, "title for advertasing N 79" },
                    { 78, 1, "description for advertising number 78", 3950, 78, "title for advertasing N 78" },
                    { 77, 11, "description for advertising number 77", 3900, 77, "title for advertasing N 77" },
                    { 76, 10, "description for advertising number 76", 3850, 76, "title for advertasing N 76" },
                    { 75, 9, "description for advertising number 75", 3800, 75, "title for advertasing N 75" },
                    { 74, 8, "description for advertising number 74", 3750, 74, "title for advertasing N 74" },
                    { 73, 7, "description for advertising number 73", 3700, 73, "title for advertasing N 73" },
                    { 72, 6, "description for advertising number 72", 3650, 72, "title for advertasing N 72" },
                    { 71, 5, "description for advertising number 71", 3600, 71, "title for advertasing N 71" },
                    { 70, 4, "description for advertising number 70", 3550, 70, "title for advertasing N 70" },
                    { 97, 9, "description for advertising number 97", 4900, 97, "title for advertasing N 97" },
                    { 69, 3, "description for advertising number 69", 3500, 69, "title for advertasing N 69" },
                    { 98, 10, "description for advertising number 98", 4950, 98, "title for advertasing N 98" },
                    { 100, 1, "description for advertising number 100", 5050, 100, "title for advertasing N 100" },
                    { 127, 6, "description for advertising number 127", 6400, 127, "title for advertasing N 127" },
                    { 126, 5, "description for advertising number 126", 6350, 126, "title for advertasing N 126" },
                    { 125, 4, "description for advertising number 125", 6300, 125, "title for advertasing N 125" },
                    { 124, 3, "description for advertising number 124", 6250, 124, "title for advertasing N 124" },
                    { 123, 2, "description for advertising number 123", 6200, 123, "title for advertasing N 123" },
                    { 122, 1, "description for advertising number 122", 6150, 122, "title for advertasing N 122" },
                    { 121, 11, "description for advertising number 121", 6100, 121, "title for advertasing N 121" },
                    { 120, 10, "description for advertising number 120", 6050, 120, "title for advertasing N 120" },
                    { 119, 9, "description for advertising number 119", 6000, 119, "title for advertasing N 119" },
                    { 118, 8, "description for advertising number 118", 5950, 118, "title for advertasing N 118" },
                    { 117, 7, "description for advertising number 117", 5900, 117, "title for advertasing N 117" },
                    { 116, 6, "description for advertising number 116", 5850, 116, "title for advertasing N 116" },
                    { 115, 5, "description for advertising number 115", 5800, 115, "title for advertasing N 115" },
                    { 114, 4, "description for advertising number 114", 5750, 114, "title for advertasing N 114" },
                    { 113, 3, "description for advertising number 113", 5700, 113, "title for advertasing N 113" },
                    { 112, 2, "description for advertising number 112", 5650, 112, "title for advertasing N 112" },
                    { 111, 1, "description for advertising number 111", 5600, 111, "title for advertasing N 111" },
                    { 110, 11, "description for advertising number 110", 5550, 110, "title for advertasing N 110" },
                    { 109, 10, "description for advertising number 109", 5500, 109, "title for advertasing N 109" },
                    { 108, 9, "description for advertising number 108", 5450, 108, "title for advertasing N 108" },
                    { 107, 8, "description for advertising number 107", 5400, 107, "title for advertasing N 107" },
                    { 106, 7, "description for advertising number 106", 5350, 106, "title for advertasing N 106" },
                    { 105, 6, "description for advertising number 105", 5300, 105, "title for advertasing N 105" },
                    { 104, 5, "description for advertising number 104", 5250, 104, "title for advertasing N 104" },
                    { 103, 4, "description for advertising number 103", 5200, 103, "title for advertasing N 103" },
                    { 102, 3, "description for advertising number 102", 5150, 102, "title for advertasing N 102" },
                    { 101, 2, "description for advertising number 101", 5100, 101, "title for advertasing N 101" },
                    { 99, 11, "description for advertising number 99", 5000, 99, "title for advertasing N 99" },
                    { 68, 2, "description for advertising number 68", 3450, 68, "title for advertasing N 68" },
                    { 67, 1, "description for advertising number 67", 3400, 67, "title for advertasing N 67" },
                    { 66, 11, "description for advertising number 66", 3350, 66, "title for advertasing N 66" },
                    { 33, 11, "description for advertising number 33", 1700, 33, "title for advertasing N 33" },
                    { 32, 10, "description for advertising number 32", 1650, 32, "title for advertasing N 32" },
                    { 31, 9, "description for advertising number 31", 1600, 31, "title for advertasing N 31" },
                    { 30, 8, "description for advertising number 30", 1550, 30, "title for advertasing N 30" },
                    { 29, 7, "description for advertising number 29", 1500, 29, "title for advertasing N 29" },
                    { 28, 6, "description for advertising number 28", 1450, 28, "title for advertasing N 28" },
                    { 27, 5, "description for advertising number 27", 1400, 27, "title for advertasing N 27" },
                    { 26, 4, "description for advertising number 26", 1350, 26, "title for advertasing N 26" },
                    { 25, 3, "description for advertising number 25", 1300, 25, "title for advertasing N 25" },
                    { 24, 2, "description for advertising number 24", 1250, 24, "title for advertasing N 24" },
                    { 23, 1, "description for advertising number 23", 1200, 23, "title for advertasing N 23" },
                    { 22, 11, "description for advertising number 22", 1150, 22, "title for advertasing N 22" },
                    { 21, 10, "description for advertising number 21", 1100, 21, "title for advertasing N 21" },
                    { 20, 9, "description for advertising number 20", 1050, 20, "title for advertasing N 20" },
                    { 19, 8, "description for advertising number 19", 1000, 19, "title for advertasing N 19" },
                    { 18, 7, "description for advertising number 18", 950, 18, "title for advertasing N 18" },
                    { 17, 6, "description for advertising number 17", 900, 17, "title for advertasing N 17" },
                    { 16, 5, "description for advertising number 16", 850, 16, "title for advertasing N 16" },
                    { 15, 4, "description for advertising number 15", 800, 15, "title for advertasing N 15" },
                    { 14, 3, "description for advertising number 14", 750, 14, "title for advertasing N 14" },
                    { 13, 2, "description for advertising number 13", 700, 13, "title for advertasing N 13" },
                    { 12, 1, "description for advertising number 12", 650, 12, "title for advertasing N 12" },
                    { 11, 11, "description for advertising number 11", 600, 11, "title for advertasing N 11" },
                    { 10, 10, "description for advertising number 10", 550, 10, "title for advertasing N 10" },
                    { 9, 9, "description for advertising number 9", 500, 9, "title for advertasing N 9" },
                    { 8, 8, "description for advertising number 8", 450, 8, "title for advertasing N 8" },
                    { 7, 7, "description for advertising number 7", 400, 7, "title for advertasing N 7" },
                    { 34, 1, "description for advertising number 34", 1750, 34, "title for advertasing N 34" },
                    { 35, 2, "description for advertising number 35", 1800, 35, "title for advertasing N 35" },
                    { 36, 3, "description for advertising number 36", 1850, 36, "title for advertasing N 36" },
                    { 37, 4, "description for advertising number 37", 1900, 37, "title for advertasing N 37" },
                    { 65, 10, "description for advertising number 65", 3300, 65, "title for advertasing N 65" },
                    { 64, 9, "description for advertising number 64", 3250, 64, "title for advertasing N 64" },
                    { 63, 8, "description for advertising number 63", 3200, 63, "title for advertasing N 63" },
                    { 62, 7, "description for advertising number 62", 3150, 62, "title for advertasing N 62" },
                    { 61, 6, "description for advertising number 61", 3100, 61, "title for advertasing N 61" }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "AdId", "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 60, 5, "description for advertising number 60", 3050, 60, "title for advertasing N 60" },
                    { 59, 4, "description for advertising number 59", 3000, 59, "title for advertasing N 59" },
                    { 58, 3, "description for advertising number 58", 2950, 58, "title for advertasing N 58" },
                    { 57, 2, "description for advertising number 57", 2900, 57, "title for advertasing N 57" },
                    { 56, 1, "description for advertising number 56", 2850, 56, "title for advertasing N 56" },
                    { 55, 11, "description for advertising number 55", 2800, 55, "title for advertasing N 55" },
                    { 54, 10, "description for advertising number 54", 2750, 54, "title for advertasing N 54" },
                    { 53, 9, "description for advertising number 53", 2700, 53, "title for advertasing N 53" },
                    { 128, 7, "description for advertising number 128", 6450, 128, "title for advertasing N 128" },
                    { 52, 8, "description for advertising number 52", 2650, 52, "title for advertasing N 52" },
                    { 50, 6, "description for advertising number 50", 2550, 50, "title for advertasing N 50" },
                    { 49, 5, "description for advertising number 49", 2500, 49, "title for advertasing N 49" },
                    { 48, 4, "description for advertising number 48", 2450, 48, "title for advertasing N 48" },
                    { 47, 3, "description for advertising number 47", 2400, 47, "title for advertasing N 47" },
                    { 46, 2, "description for advertising number 46", 2350, 46, "title for advertasing N 46" },
                    { 45, 1, "description for advertising number 45", 2300, 45, "title for advertasing N 45" },
                    { 44, 11, "description for advertising number 44", 2250, 44, "title for advertasing N 44" },
                    { 43, 10, "description for advertising number 43", 2200, 43, "title for advertasing N 43" },
                    { 42, 9, "description for advertising number 42", 2150, 42, "title for advertasing N 42" },
                    { 41, 8, "description for advertising number 41", 2100, 41, "title for advertasing N 41" },
                    { 40, 7, "description for advertising number 40", 2050, 40, "title for advertasing N 40" },
                    { 39, 6, "description for advertising number 39", 2000, 39, "title for advertasing N 39" },
                    { 38, 5, "description for advertising number 38", 1950, 38, "title for advertasing N 38" },
                    { 51, 7, "description for advertising number 51", 2600, 51, "title for advertasing N 51" },
                    { 254, 1, "description for advertising number 254", 12750, 115, "title for advertasing N 254" },
                    { 129, 8, "description for advertising number 129", 6500, 129, "title for advertasing N 129" },
                    { 131, 10, "description for advertising number 131", 6600, 131, "title for advertasing N 131" },
                    { 221, 1, "description for advertising number 221", 11100, 82, "title for advertasing N 221" },
                    { 220, 11, "description for advertising number 220", 11050, 81, "title for advertasing N 220" },
                    { 219, 10, "description for advertising number 219", 11000, 80, "title for advertasing N 219" },
                    { 218, 9, "description for advertising number 218", 10950, 79, "title for advertasing N 218" },
                    { 217, 8, "description for advertising number 217", 10900, 78, "title for advertasing N 217" },
                    { 216, 7, "description for advertising number 216", 10850, 77, "title for advertasing N 216" },
                    { 215, 6, "description for advertising number 215", 10800, 76, "title for advertasing N 215" },
                    { 214, 5, "description for advertising number 214", 10750, 75, "title for advertasing N 214" },
                    { 213, 4, "description for advertising number 213", 10700, 74, "title for advertasing N 213" },
                    { 212, 3, "description for advertising number 212", 10650, 73, "title for advertasing N 212" },
                    { 211, 2, "description for advertising number 211", 10600, 72, "title for advertasing N 211" },
                    { 210, 1, "description for advertising number 210", 10550, 71, "title for advertasing N 210" },
                    { 209, 11, "description for advertising number 209", 10500, 70, "title for advertasing N 209" },
                    { 208, 10, "description for advertising number 208", 10450, 69, "title for advertasing N 208" },
                    { 207, 9, "description for advertising number 207", 10400, 68, "title for advertasing N 207" },
                    { 206, 8, "description for advertising number 206", 10350, 67, "title for advertasing N 206" },
                    { 205, 7, "description for advertising number 205", 10300, 66, "title for advertasing N 205" },
                    { 204, 6, "description for advertising number 204", 10250, 65, "title for advertasing N 204" },
                    { 203, 5, "description for advertising number 203", 10200, 64, "title for advertasing N 203" },
                    { 202, 4, "description for advertising number 202", 10150, 63, "title for advertasing N 202" },
                    { 201, 3, "description for advertising number 201", 10100, 62, "title for advertasing N 201" },
                    { 200, 2, "description for advertising number 200", 10050, 61, "title for advertasing N 200" },
                    { 199, 1, "description for advertising number 199", 10000, 60, "title for advertasing N 199" },
                    { 198, 11, "description for advertising number 198", 9950, 59, "title for advertasing N 198" },
                    { 197, 10, "description for advertising number 197", 9900, 58, "title for advertasing N 197" },
                    { 196, 9, "description for advertising number 196", 9850, 57, "title for advertasing N 196" },
                    { 195, 8, "description for advertising number 195", 9800, 56, "title for advertasing N 195" },
                    { 222, 2, "description for advertising number 222", 11150, 83, "title for advertasing N 222" },
                    { 194, 7, "description for advertising number 194", 9750, 55, "title for advertasing N 194" },
                    { 223, 3, "description for advertising number 223", 11200, 84, "title for advertasing N 223" },
                    { 225, 5, "description for advertising number 225", 11300, 86, "title for advertasing N 225" },
                    { 252, 10, "description for advertising number 252", 12650, 113, "title for advertasing N 252" },
                    { 251, 9, "description for advertising number 251", 12600, 112, "title for advertasing N 251" },
                    { 250, 8, "description for advertising number 250", 12550, 111, "title for advertasing N 250" },
                    { 249, 7, "description for advertising number 249", 12500, 110, "title for advertasing N 249" },
                    { 248, 6, "description for advertising number 248", 12450, 109, "title for advertasing N 248" },
                    { 247, 5, "description for advertising number 247", 12400, 108, "title for advertasing N 247" },
                    { 246, 4, "description for advertising number 246", 12350, 107, "title for advertasing N 246" },
                    { 245, 3, "description for advertising number 245", 12300, 106, "title for advertasing N 245" },
                    { 244, 2, "description for advertising number 244", 12250, 105, "title for advertasing N 244" },
                    { 243, 1, "description for advertising number 243", 12200, 104, "title for advertasing N 243" },
                    { 242, 11, "description for advertising number 242", 12150, 103, "title for advertasing N 242" },
                    { 241, 10, "description for advertising number 241", 12100, 102, "title for advertasing N 241" },
                    { 240, 9, "description for advertising number 240", 12050, 101, "title for advertasing N 240" },
                    { 239, 8, "description for advertising number 239", 12000, 100, "title for advertasing N 239" },
                    { 238, 7, "description for advertising number 238", 11950, 99, "title for advertasing N 238" },
                    { 237, 6, "description for advertising number 237", 11900, 98, "title for advertasing N 237" },
                    { 236, 5, "description for advertising number 236", 11850, 97, "title for advertasing N 236" },
                    { 235, 4, "description for advertising number 235", 11800, 96, "title for advertasing N 235" },
                    { 234, 3, "description for advertising number 234", 11750, 95, "title for advertasing N 234" },
                    { 233, 2, "description for advertising number 233", 11700, 94, "title for advertasing N 233" },
                    { 232, 1, "description for advertising number 232", 11650, 93, "title for advertasing N 232" },
                    { 231, 11, "description for advertising number 231", 11600, 92, "title for advertasing N 231" },
                    { 230, 10, "description for advertising number 230", 11550, 91, "title for advertasing N 230" },
                    { 229, 9, "description for advertising number 229", 11500, 90, "title for advertasing N 229" },
                    { 228, 8, "description for advertising number 228", 11450, 89, "title for advertasing N 228" },
                    { 227, 7, "description for advertising number 227", 11400, 88, "title for advertasing N 227" },
                    { 226, 6, "description for advertising number 226", 11350, 87, "title for advertasing N 226" },
                    { 224, 4, "description for advertising number 224", 11250, 85, "title for advertasing N 224" },
                    { 193, 6, "description for advertising number 193", 9700, 54, "title for advertasing N 193" },
                    { 192, 5, "description for advertising number 192", 9650, 53, "title for advertasing N 192" },
                    { 191, 4, "description for advertising number 191", 9600, 52, "title for advertasing N 191" },
                    { 158, 4, "description for advertising number 158", 7950, 19, "title for advertasing N 158" },
                    { 157, 3, "description for advertising number 157", 7900, 18, "title for advertasing N 157" },
                    { 156, 2, "description for advertising number 156", 7850, 17, "title for advertasing N 156" },
                    { 155, 1, "description for advertising number 155", 7800, 16, "title for advertasing N 155" },
                    { 154, 11, "description for advertising number 154", 7750, 15, "title for advertasing N 154" },
                    { 153, 10, "description for advertising number 153", 7700, 14, "title for advertasing N 153" },
                    { 152, 9, "description for advertising number 152", 7650, 13, "title for advertasing N 152" },
                    { 151, 8, "description for advertising number 151", 7600, 12, "title for advertasing N 151" },
                    { 150, 7, "description for advertising number 150", 7550, 11, "title for advertasing N 150" },
                    { 149, 6, "description for advertising number 149", 7500, 10, "title for advertasing N 149" },
                    { 148, 5, "description for advertising number 148", 7450, 9, "title for advertasing N 148" },
                    { 147, 4, "description for advertising number 147", 7400, 8, "title for advertasing N 147" },
                    { 146, 3, "description for advertising number 146", 7350, 7, "title for advertasing N 146" },
                    { 145, 2, "description for advertising number 145", 7300, 6, "title for advertasing N 145" },
                    { 144, 1, "description for advertising number 144", 7250, 5, "title for advertasing N 144" },
                    { 143, 11, "description for advertising number 143", 7200, 4, "title for advertasing N 143" },
                    { 142, 10, "description for advertising number 142", 7150, 3, "title for advertasing N 142" },
                    { 141, 9, "description for advertising number 141", 7100, 2, "title for advertasing N 141" },
                    { 140, 8, "description for advertising number 140", 7050, 1, "title for advertasing N 140" },
                    { 139, 7, "description for advertising number 139", 7000, 139, "title for advertasing N 139" },
                    { 138, 6, "description for advertising number 138", 6950, 138, "title for advertasing N 138" },
                    { 137, 5, "description for advertising number 137", 6900, 137, "title for advertasing N 137" },
                    { 136, 4, "description for advertising number 136", 6850, 136, "title for advertasing N 136" },
                    { 135, 3, "description for advertising number 135", 6800, 135, "title for advertasing N 135" },
                    { 134, 2, "description for advertising number 134", 6750, 134, "title for advertasing N 134" },
                    { 133, 1, "description for advertising number 133", 6700, 133, "title for advertasing N 133" },
                    { 132, 11, "description for advertising number 132", 6650, 132, "title for advertasing N 132" },
                    { 159, 5, "description for advertising number 159", 8000, 20, "title for advertasing N 159" },
                    { 160, 6, "description for advertising number 160", 8050, 21, "title for advertasing N 160" },
                    { 161, 7, "description for advertising number 161", 8100, 22, "title for advertasing N 161" },
                    { 162, 8, "description for advertising number 162", 8150, 23, "title for advertasing N 162" },
                    { 190, 3, "description for advertising number 190", 9550, 51, "title for advertasing N 190" },
                    { 189, 2, "description for advertising number 189", 9500, 50, "title for advertasing N 189" },
                    { 188, 1, "description for advertising number 188", 9450, 49, "title for advertasing N 188" },
                    { 187, 11, "description for advertising number 187", 9400, 48, "title for advertasing N 187" },
                    { 186, 10, "description for advertising number 186", 9350, 47, "title for advertasing N 186" },
                    { 185, 9, "description for advertising number 185", 9300, 46, "title for advertasing N 185" },
                    { 184, 8, "description for advertising number 184", 9250, 45, "title for advertasing N 184" },
                    { 183, 7, "description for advertising number 183", 9200, 44, "title for advertasing N 183" },
                    { 182, 6, "description for advertising number 182", 9150, 43, "title for advertasing N 182" },
                    { 181, 5, "description for advertising number 181", 9100, 42, "title for advertasing N 181" },
                    { 180, 4, "description for advertising number 180", 9050, 41, "title for advertasing N 180" },
                    { 179, 3, "description for advertising number 179", 9000, 40, "title for advertasing N 179" },
                    { 178, 2, "description for advertising number 178", 8950, 39, "title for advertasing N 178" },
                    { 130, 9, "description for advertising number 130", 6550, 130, "title for advertasing N 130" },
                    { 177, 1, "description for advertising number 177", 8900, 38, "title for advertasing N 177" },
                    { 175, 10, "description for advertising number 175", 8800, 36, "title for advertasing N 175" },
                    { 174, 9, "description for advertising number 174", 8750, 35, "title for advertasing N 174" },
                    { 173, 8, "description for advertising number 173", 8700, 34, "title for advertasing N 173" },
                    { 172, 7, "description for advertising number 172", 8650, 33, "title for advertasing N 172" },
                    { 171, 6, "description for advertising number 171", 8600, 32, "title for advertasing N 171" },
                    { 170, 5, "description for advertising number 170", 8550, 31, "title for advertasing N 170" },
                    { 169, 4, "description for advertising number 169", 8500, 30, "title for advertasing N 169" },
                    { 168, 3, "description for advertising number 168", 8450, 29, "title for advertasing N 168" },
                    { 167, 2, "description for advertising number 167", 8400, 28, "title for advertasing N 167" },
                    { 166, 1, "description for advertising number 166", 8350, 27, "title for advertasing N 166" },
                    { 165, 11, "description for advertising number 165", 8300, 26, "title for advertasing N 165" },
                    { 164, 10, "description for advertising number 164", 8250, 25, "title for advertasing N 164" },
                    { 163, 9, "description for advertising number 163", 8200, 24, "title for advertasing N 163" },
                    { 176, 11, "description for advertising number 176", 8850, 37, "title for advertasing N 176" },
                    { 6, 6, "description for advertising number 6", 350, 6, "title for advertasing N 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 499);

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 2, "1 room apartmant for cheap price", 10000, 11, "1 room apartmant" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 2,
                columns: new[] { "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { "2 room apartmant for cheap price", 20000, 11, "2 room apartmant" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 2, "3 room apartmant for cheap price", 30000, 11, "3 room apartmant" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 2, "small house  for cheap price", 50000, 12, "small house" });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "AdId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Desc", "Price", "SubCategoryId", "Title" },
                values: new object[] { 2, "Big luxury house  for great price", 100000, 12, "big house" });
        }
    }
}
