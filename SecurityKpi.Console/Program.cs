using System;
using System.Linq;
using System.Text;
using SecurityKpi.Lab1;
using SecurityKpi.Lab4;

Generator.GenerateSha1Passwords();

const string text = @"G0IFOFVMLRAPI1QJbEQDbFEYOFEPJxAfI10JbEMFIUAAKRAfOVIfOFkYOUQFI15ML1kcJFUeYhA4IxAeKVQZL1VMOFgJbFMDIUAAKUgFOElMI1ZMOFgFPxADIlVMO1VMO1kAIBAZP1VMI14ANRAZPEAJPlMNP1VMIFUYOFUePxxMP19MOFgJbFsJNUMcLVMJbFkfbF8CIElMfgZNbGQDbFcJOBAYJFkfbF8CKRAeJVcEOBANOUQDIVEYJVMNIFwVbEkDORAbJVwAbEAeI1INLlwVbF4JKVRMOF9MOUMJbEMDIVVMP18eOBADKhALKV4JOFkPbFEAK18eJUQEIRBEO1gFL1hMO18eJ1UIbEQEKRAOKUMYbFwNP0RMNVUNPhlAbEMFIUUALUQJKBANIl4JLVwFIldMI0JMK0INKFkJIkRMKFUfL1UCOB5MH1UeJV8ZP1wVYBAbPlkYKRAFOBAeJVcEOBACI0dAbEkDORAbJVwAbF4JKVRMJURMOF9MKFUPJUAEKUJMOFgJbF4JNERMI14JbFEfbEcJIFxCbHIJLUJMJV5MIVkCKBxMOFgJPlVLPxACIxAfPFEPKUNCbDoEOEQcPwpDY1QDL0NCK18DK1wJYlMDIR8II1MZIVUCOB8IYwEkFQcoIB1ZJUQ1CAMvE1cHOVUuOkYuCkA4eHMJL3c8JWJffHIfDWIAGEA9Y1UIJURTOUMccUMELUIFIlc=";
var result = XorTask.GetResult(text).ToList();
var newResult = XorTask.GetResultRepeatingKey(text);
// for (var i = 0; i < 256; i++)
// {
//     Console.WriteLine("=====================================START========================================");
//     Console.WriteLine(result[i]);
//     Console.WriteLine("=====================================FINISH========================================");
// }
byte[] data = Convert.FromBase64String(text);
string decodedString = Encoding.UTF8.GetString(data);
string t1 = "";
string t2 = "";
string t3 = "";
for (var i = 0; i < decodedString.Length; i++)
{
    switch (i % 3)
    {
        case 0:
            t1 += decodedString[i];
            break;
        case 1:
            t2 += decodedString[i];
            break;
        case 2:
            t3 += decodedString[i];
            break;
    }
}
var t1Xor = XorTask.GetResult(t1).ToList();
var t2Xor = XorTask.GetResult(t2).ToList();
var t3Xor = XorTask.GetResult(t3).ToList();
var good1 = t1Xor[76];
var good2 = t2Xor[48];
var good3 = t3Xor[108];
// for (var i = 0; i < 256; i++)
// {
//     Console.WriteLine($"=====================================START{i}========================================");
//     Console.WriteLine(t3Xor[i]);
//     Console.WriteLine("=====================================FINISH========================================");
// }
var goodres = "";
for (var i = 0; i < 180; i++)
{
    goodres += good1[i];
    goodres += good2[i];
    goodres += good3[i];
}

goodres += good1[180] + good2[180];
Console.WriteLine(goodres);

var task4 =
    "UMUPLYRXOYRCKTYYPDYZTOUYDZHYJYUNTOMYTOLTKAOHOKZCMKAVZDYBRORPTHQLSERUOERMKZGQJOIDJUDNDZATUVOTTLMQBOWNMERQTDTUFKZCMTAZMEOJJJOXMERKJHACMTAZATIZOEPPJKIJJNOCFEPLFBUNQHHPPKYYKQAZKTOTIKZNXPGQZQAZKTOTIZYNIUISZIAELMKSJOYUYYTHNEIEOESULOXLUEYGBEUGJLHAJTGGOEOSMJHNFJALFBOHOKAGPTIHKNMKTOUUUMUQUDATUEIRBKYUQTWKJKZNLDRZBLTJJJIDJYSULJARKHKUKBISBLTOJRATIOITHYULFBITOVHRZIAXFDRNIORLZEYUUJGEBEYLNMYCZDITKUXSJEJCFEUGJJOTQEZNORPNUDPNQIAYPEDYPDYTJAIGJYUZBLTJJYYNTMSEJYFNKHOTJARNLHHRXDUPZIALZEDUYAOSBBITKKYLXKZNQEYKKZTOKHWCOLKURTXSKKAGZEPLSYHTMKRKJIIQZDTNHDYXMEIRMROGJYUMHMDNZIOTQEKURTXSKKAGZEPLSYHTMKRKJIIQZDTNROAUYLOTIMDQJYQXZDPUMYMYPYRQNYFNUYUJJEBEOMDNIYUOHYYYJHAOQDRKKZRRJEPCFNRKJUHSJOIRQYDZBKZURKDNNEOYBTKYPEJCMKOAJORKTKJLFIOQHYPNBTAVZEUOBTKKBOWSBKOSKZUOZIHQSLIJJMSURHYZJJZUKOAYKNIYKKZNHMITBTRKBOPNUYPNTTPOKKZNKKZNLKZCFNYTKKQNUYGQJKZNXYDNJYYMEZRJJJOXMERKJVOSJIOSIQAGTZYNZIOYSMOHQDTHMEDWJKIULNOTBCALFBJNTOGSJKZNEEYYKUIXLEUNLNHNMYUOMWHHOOQNUYGQJKZLZJZLOLATSEHQKTAYPYRZJYDNQDTHBTKYKYFGJRRUFEWNTHAXFAHHODUPZMXUMKXUFEOTIMUNQIHGPAACFKATIKIZBTOTIKZNKKZNLORUKMLLFBUUQKZNLEOHIEOHEDRHXOTLMIRKLEAHUYXCZYTGUYXCZYTIUYXCZYTCVJOEBKOHE";
string p1 = "";
string p2 = "";
string p3 = "";
string p4 = "";
for (var i = 0; i < task4.Length; i++)
{
    switch (i % 4)
    {
        case 0:
            p1 += task4[i];
            break;
        case 1:
            p2 += task4[i];
            break;
        case 2:
            p3 += task4[i];
            break;
        case 3:
            p4 += task4[i];
            break;
    }
}
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4);