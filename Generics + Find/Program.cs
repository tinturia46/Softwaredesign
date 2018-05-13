using System;
using System.Collections.Generic;
using System.Globalization;

namespace L5 {

 class Program {
  static void Main(string[] args) {
   var tree = new Tree < String > ();
   var root = tree.CreateNode("root");
   var child1 = tree.CreateNode("child1");
   var child2 = tree.CreateNode("child2");
   root.AppendChild(child1);
   root.AppendChild(child2);
   var grand11 = tree.CreateNode("grand11");
   var grand12 = tree.CreateNode("grand12");
   var grand13 = tree.CreateNode("grand13");
   child1.AppendChild(grand11);
   child1.AppendChild(grand12);
   child1.AppendChild(grand13);
   var grand21 = tree.CreateNode("grand21");
   child2.AppendChild(grand21);
   child1.RemoveChild(grand12);

   root.PrintTree();
   List < TreeNode < String >> resultList = root.Find("child21", new List < TreeNode < string >> ());
   Console.WriteLine("terms found in tree: " + resultList.Count);

  }

  public class Tree < T > {
   public TreeNode < T > CreateNode(T content) {
    return new TreeNode < T > (content);
   }
  }

  public class TreeNode < T > {
   public TreeNode < T > parent;
   public List < TreeNode < T >> children;
   public T nodeContent;

   public TreeNode(T content) {
    nodeContent = content;
    children = new List < TreeNode < T >> ();
   }

   public void AppendChild(TreeNode < T > node) {
    children.Add(node);
    node.parent = this;
   }

   public void RemoveChild(TreeNode < T > node) {
    children.Remove(node);
   }

   public void PrintTree(String Hierarchy = "") {
    Console.WriteLine(Hierarchy + nodeContent.ToString());

    if (children.Count > 0) {
     foreach(var node in children) {
      node.PrintTree(Hierarchy + "*");
     }
    }

   }
   public List < TreeNode < T >> Find(T term, List < TreeNode < T >> ListF = null) {

    if (ListF == null) {
     ListF = new List < TreeNode < T >> ();
    }
    if (children.Equals(term)) {
     ListF.Add(this);
    }
    foreach(TreeNode < T > node in children) {
     node.Find(term, ListF);
    }
    return ListF;

   }

  }
 }
}