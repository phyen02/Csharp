/* Tạo một hàm dịch một chuỗi DNA đã cho thành RNA.
Axit deoxyribonucleic, DNA là phân tử lưu trữ thông tin chính trong các hệ thống sinh học.
Nó bao gồm bốn bazơ axit nucleic Guanine ('G'), Cytosine ('C'), Adenine ('A') và Thymine ('T').
Axit ribonucleic, RNA, là phân tử truyền tin chính trong tế bào.
RNA có cấu trúc hóa học hơi khác so với DNA và không chứa Thymine. Trong RNA, Thymine được thay thế bằng một axit nucleic khác là Uracil ('U').
Ví dụ: "GCAT"  =>  "GCAU"
Chuỗi đầu vào có thể có độ dài tùy ý - cụ thể là có thể để trống.
Tất cả đầu vào đều được đảm bảo là hợp lệ, tức là mỗi chuỗi đầu vào sẽ chỉ bao gồm 'G', 'C', 'A' và/hoặc 'T'.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string dna = "TTTT";
            string rna = DNAtoRNA(dna);
            Console.WriteLine(rna);
        }

        public static string DNAtoRNA(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}