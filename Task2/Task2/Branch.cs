using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Branch
    {
        // Create new branch
        public List<Branch> branches = new List<Branch>();

        // Method for finding depth of structure
        public static int DepthOfStructure(Branch root)
        {
            // Base case
            if (root == null)
            {
                return 0;
            }
            // Find maximum depth recursively
            int maxChildDepth = 0;
            foreach (Branch child in root.branches)
            {
                int currentDepth = DepthOfStructure(child);
                if (currentDepth > maxChildDepth)
                {
                    maxChildDepth = currentDepth;
                }
            }
            return maxChildDepth + 1;
        }
    }
}
