using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PA4WebRole
{
    public class TrieNode
    {
        public bool isQUery = false;
        public Dictionary<char, TrieNode> tDict = new Dictionary<char, TrieNode>();
    }
}