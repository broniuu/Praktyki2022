var text = "dasdasd asdasdasd fsdfsfd \n ddgdas kkdkdl";

Console.WriteLine(string.Concat(SplitText(text)));

static String[] SplitText(String text)
{
    return text.Split(new char[] { ' ', '\n'});
}
