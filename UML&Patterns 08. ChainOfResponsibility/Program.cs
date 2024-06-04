// COR, Chain of Responsibility

//CompilerCOR compiler = new SyntaxAnalyzer()
//                            .SetNext(new LexicalAnalyzer()
//                            .SetNext(new Linker()));

CompilerCOR compiler = new SyntaxAnalyzer().SetNext(new LexicalAnalyzer()).SetNext(new Linker());
compiler.Handle();

abstract class CompilerCOR
{
    protected CompilerCOR? Next { get; set; }
    public virtual CompilerCOR? SetNext(CompilerCOR? next)
    {
        Next = next;
        return this;    
    }
    public abstract void Handle();
}

class SyntaxAnalyzer : CompilerCOR
{
    public override void Handle()
    {
        Console.WriteLine("Syntax Analyzer");
        Next?.Handle();
    }
}

class LexicalAnalyzer : CompilerCOR
{
    public override void Handle()
    {
        Console.WriteLine("Lexical Analyzer");
        Next?.Handle();
    }
}

class Linker : CompilerCOR
{
    public override void Handle()
    {
        Console.WriteLine("Linker");
        Next?.Handle();
    }
}

