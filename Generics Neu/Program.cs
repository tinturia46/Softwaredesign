using System;
using System.Collections.Generic;


/*
public class Auto<PLATZHALTER, PLATZHALTER_FUER_TUEREN>
{
    public PLATZHALTER_FUER_TUEREN tueren;
    
    public double PS;
    public int Zylinder;
    public double Hubraum;
    public PLATZHALTER Farbe;
}
*/
namespace Generics_Neu
{
    class Tree<PLATZHALTER>{
        public TreeNode<PLATZHALTER> CreateNode(PLATZHALTER wert)
        {
        TreeNode<PLATZHALTER> retWert = new TreeNode<PLATZHALTER>();
        retWert.Nutzdaten = wert;

        }

    
    }
    class TreeNode<PLATZHALTER>{
        public PLATZHALTER Nutzdaten;
        public List<TreeNode<PLATZHALTER>> KinderListe = new List<TreeNode<PLATZHALTER>>();

        public void AppendChild(TreeNode<PLATZHALTER> child){
KinderListe.Add(child);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>();

        }
        
    }
}
