namespace ActiveMesa.FSharper.Feature.Services.FSharp.CodeStructure

open JetBrains.ReSharper.Feature.Services.CodeStructure

type FSharpCodeStuctureAspect(element, declaration) =
  inherit CodeStructureDeclarationAspects(declaration)

  let myElement = element

//  internal class CSharpCodeStructureAspect : CodeStructureDeclarationAspects
//{
//    // Fields
//    private readonly CSharpCodeStructureDeclaredElement myElement;
//
//    // Methods
//    public CSharpCodeStructureAspect(CSharpCodeStructureDeclaredElement element, IDeclaration declaration) : base(declaration)
//    {
//        this.myElement = element;
//    }
//
//    protected override IList<string> CalculateQuickSearchTexts(IDeclaration declaration)
//    {
//        if (!declaration.IsValid())
//        {
//            return EmptyArray<string>.Instance;
//        }
//        IInterfaceQualificationOwner interfaceQualificationOwner = declaration as IInterfaceQualificationOwner;
//        if ((interfaceQualificationOwner != null) && (interfaceQualificationOwner.InterfaceQualificationReference != null))
//        {
//            return new string[] { interfaceQualificationOwner.GetDeclaredShortName(), interfaceQualificationOwner.InterfaceQualificationReference.ShortName };
//        }
//        IConstructorDeclaration ctor = declaration as IConstructorDeclaration;
//        if (ctor != null)
//        {
//            return new string[] { ctor.DeclaredName, "new" };
//        }
//        IIndexerDeclaration indexer = declaration as IIndexerDeclaration;
//        if (indexer != null)
//        {
//            return new string[] { indexer.DeclaredName, "this" };
//        }
//        IDestructorDeclaration dtor = declaration as IDestructorDeclaration;
//        if (dtor != null)
//        {
//            return new string[] { dtor.DeclaredName, "Finalize" };
//        }
//        IOperatorDeclaration oper = declaration as IOperatorDeclaration;
//        if (oper != null)
//        {
//            return new string[] { oper.DeclaredName, "operator" };
//        }
//        IEventDeclaration evt = declaration as IEventDeclaration;
//        if (evt != null)
//        {
//            return new string[] { evt.DeclaredName, "event" };
//        }
//        return base.CalculateQuickSearchTexts(declaration);
//    }
//
//    public override bool CanMoveElements(RelativeLocation location, IList<CodeStructureElement> dropElements)
//    {
//        return CSharpCodeStructureProvider.CanMoveElements(this.myElement, location, dropElements);
//    }
//
//    public override DocumentRange[] GetNavigationRanges()
//    {
//        if (!(this.Declaration is IClassLikeDeclaration) && !(this.Declaration is INamespaceDeclaration))
//        {
//            return base.GetNavigationRanges();
//        }
//        if (!this.Declaration.IsValid())
//        {
//            return EmptyArray<DocumentRange>.Instance;
//        }
//        ITreeNode token = CSharpCodeStructureProvider.GetLastToken(this.Declaration);
//        return new DocumentRange[] { this.Declaration.GetNavigationRange(), token.GetNavigationRange() };
//    }
//
//    public override void MoveElements(RelativeLocation location, IList<CodeStructureElement> dropElements)
//    {
//        CSharpCodeStructureProvider.MoveElements(this.myElement, location, dropElements);
//    }
//
//    public override void Present(StructuredPresenter<TreeModelNode, IPresentableItem> presenter, IPresentableItem item, TreeModelNode modelNode, PresentationState state)
//    {
//        base.Present(presenter, item, modelNode, state);
//        if (this.myElement.InheritanceInformation != null)
//        {
//            item.Images.Add(this.myElement.InheritanceInformation.Image, this.myElement.InheritanceInformation.ToolTip, ImagePlacement.LEFT);
//        }
//        else
//        {
//            CSharpCodeStructureDeclaredElement csParentElement = this.myElement.Parent as CSharpCodeStructureDeclaredElement;
//            if ((csParentElement != null) && csParentElement.ChildrenHasInheritance)
//            {
//                item.Images.Add(ImageLoader.GetImage("empty", new Assembly[0]), "");
//            }
//        }
//    }
//
//    // Properties
//    public override bool InitiallyExpanded
//    {
//        get
//        {
//            return !this.myElement.InitiallyCollapsed;
//        }
//    }
//}
//
// 
//Collapse Methods
// 
