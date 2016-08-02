using JetBrains.Annotations;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace AlexPovar.ReSharperHelpers.ContextActions.ChopInline
{
  public class OnelineMethodArgumentsAction : ChopInlineMethodActionBase
  {
    public OnelineMethodArgumentsAction([NotNull] ICSharpParametersOwnerDeclaration methodDeclaration)
      : base(methodDeclaration)
    {
      //see ChangeModifierAction 
    }

    public override string Text => "One line method arguments";

    protected override void DoPutNewIndents(IFormalParameterList parameters)
    {
      //Do nothing
    }
  }
}