# Advanced Data Structure Concepts

A comprehensive C# learning repository featuring 18 advanced data structure topics with 99+ practice projects. Each topic includes multiple hands-on projects demonstrating real-world applications and best practices.

## 📚 Repository Overview

This repository is designed for developers who want to master advanced data structures in C#. Each directory contains 5+ practice projects that progressively build understanding from basics to advanced implementations.

### Key Features
- ✅ **99+ Practice Projects** - Hands-on learning for every concept
- ✅ **Multiple Implementations** - Different approaches to solve problems
- ✅ **Real-World Applications** - Practical use cases and scenarios
- ✅ **Progressive Learning** - Projects organized from basic to advanced
- ✅ **C# Focus** - .NET Framework 4.8 with standard libraries

---

## 📂 Directory Structure & Topics

### 1. **01_BoxingAndUnboxing** (5 projects)
Understanding value type to reference type conversions in C#
- Boxing & Unboxing fundamentals
- Boxing with Arrays
- Boxing with Collections
- Performance implications
- Boxing with Interfaces

**Topics:** Memory management, boxing overhead, interface boxing, unboxing exceptions

---

### 2. **02_Lists** (11 projects)
Generic and flexible collection management
- Working with Lists
- Inserting and removing elements
- Data aggregation with LINQ
- Filtering and sorting
- Searching operations (integer, string, custom objects)
- Array/List conversions

**Topics:** Generic collections, LINQ operations, collection manipulation, search algorithms

---

### 3. **03_DictionaryAndHashTable** (5 projects)
Key-value pair storage and retrieval
- Dictionary basics
- HashTable operations
- TryGetValue patterns
- LINQ with Dictionaries
- GroupBy and chaining

**Topics:** Hash-based lookups, key-value relationships, performance optimization

---

### 4. **04_HashSet** (14 projects)
Unique element storage and set operations
- Working with HashSet
- Existence checking
- Removing duplicates
- LINQ integration
- Union, Intersection, Difference operations
- Set equality checks

**Topics:** Set theory, duplicate removal, set operations, performance

---

### 5. **05_SortedList** (5 projects)
Automatically sorted key-value collections
- SortedList basics
- LINQ with SortedList
- Advanced LINQ operations (GroupBy)
- Custom object operations
- **NEW:** Complex scenarios with custom objects

**Topics:** Sorted collections, automatic ordering, range queries

---

### 6. **06_SortedSet** (5 projects)
Automatically sorted unique elements
- SortedSet fundamentals
- LINQ integration
- Advanced sorting scenarios
- Set operations on sorted data

**Topics:** Sorted unique collections, balanced trees, set operations

---

### 7. **07_SortedDictionary** (5 projects)
Automatically sorted key-value pairs
- SortedDictionary operations
- LINQ queries
- Custom comparers
- Range operations and merging

**Topics:** Sorted key-value storage, custom sorting, tree-based collections

---

### 8. **08_ArrayList** (5 projects)
Legacy non-generic collection handling
- ArrayList fundamentals
- CRUD operations
- Searching and sorting
- Custom object handling
- LINQ with Cast

**Topics:** Non-generic collections, type casting, legacy code

---

### 9. **09_ObservableCollection** (5 projects)
Dynamic collections with change notification
- Working with ObservableCollection
- Change event handling
- LINQ mini-project
- **NEW:** Data binding scenarios
- **NEW:** Advanced filtering and synchronization

**Topics:** Event-driven collections, data binding, MVVM patterns

---

### 10. **10_DataStructuresReview** (5 projects)
Comprehensive data structure comparison
- Stack implementation
- Queue implementation
- LinkedList usage
- Array operations
- **NEW:** Performance comparison of all structures

**Topics:** Performance analysis, structure selection, benchmarking

---

### 11. **11_BitArray** (5 projects)
Efficient bit-level storage and manipulation
- BitArray basics
- Bitwise operators
- Copy and iteration
- Permission systems
- Prime number sieve

**Topics:** Bit manipulation, bitwise operations, space efficiency

---

### 12. **12_JaggedArray** (5 projects)
Array of arrays with varying dimensions
- Jagged array basics
- LINQ with jagged arrays
- Student score analysis
- Quarterly sales insights
- **NEW:** Matrix operations

**Topics:** Multi-dimensional arrays, matrix operations, data analysis

---

### 13. **13_Tuples** (6 projects)
Value type collections with multiple elements
- Tuple fundamentals
- LINQ with Tuples
- Shape and nesting
- Function returns with Tuples
- Deconstruction and swapping
- Analytics with ValueTuples

**Topics:** Tuple benefits, deconstruction, return multiple values

---

### 14. **14_CollectionInterfaces** (6 projects)
Understanding collection contracts and hierarchies
- IEnumerable interface
- ICollection interface
- IList interface
- IDictionary interface
- ISet interface
- IComparable interface

**Topics:** Interface contracts, polymorphism, collection hierarchy

---

### 15. **Tree** (5 projects)
Hierarchical data structure implementations
- General Tree concepts
- Binary Tree basics
- **NEW:** Binary Search Tree (search, insert, delete)
- **NEW:** Tree Traversal (in-order, pre-order, post-order, level-order)
- **NEW:** Balanced Trees (AVL Tree self-balancing)

**Topics:** Tree structures, BST operations, traversal algorithms, balancing

---

### 16. **Graph** (5 projects)
Network and relationship representations
- Graph matrix implementation
- Graph adjacency list
- **NEW:** BFS & DFS traversals
- **NEW:** Shortest path (Dijkstra's algorithm)
- **NEW:** Connectivity and Union-Find

**Topics:** Graph traversal, shortest path, connectivity, cycle detection

---

### 17. **Heap** (5 projects)
Priority-based binary tree structures
- Insert operations
- Peek operations
- Extract/Delete operations
- Max Heap implementation
- **NEW:** Heap Sort algorithm

**Topics:** Min/Max heaps, heap operations, sorting algorithms

---

### 18. **PriorityQueue** (5 projects)
Queue with priority-based ordering
- Priority Queue operations
- **NEW:** Priority Queue with Heap implementation
- **NEW:** Task scheduler application
- **NEW:** Dijkstra's algorithm with Priority Queue
- **NEW:** Median finder using two heaps

**Topics:** Priority queues, scheduling, advanced algorithms, heap applications

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2015 or later
- .NET Framework 4.8
- C# 6.0 or higher

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/MohamedRaghebOmer/Data-Structure-Advanced-Concepts.git
   cd Data-Structure-Advanced-Concepts
   ```

2. Open individual projects in Visual Studio:
   - Each project is a standalone C# console application
   - Navigate to the desired directory
   - Open the `.csproj` or `.sln` file

### Running Projects
Each project can be run independently:
```bash
# Navigate to project directory
cd [DirectoryNumber]_[TopicName]/[ProjectName]

# Build and run
dotnet build
dotnet run
```

Or in Visual Studio:
1. Open the solution file (`.sln`)
2. Set the project as startup project
3. Press F5 or click "Start Debugging"

---

## 📋 Project Naming Convention

All projects follow a consistent naming pattern:
```
[DirectoryNumber]_[TopicName]/
  └── [ProjectNumber]_[ProjectName]/
      ├── Program.cs                    # Main implementation
      ├── [ProjectName].csproj          # Project file
      ├── App.config                    # Configuration
      └── Properties/
          └── AssemblyInfo.cs           # Assembly metadata
```

**Examples:**
- `01_BoxingAndUnboxing/02_BoxingWithArrays/`
- `15_Tree/03_BinarySearchTree/`
- `18_PriorityQueue/05_MedianFinder/`

---

## 💡 Learning Path

### Beginner Level
Start with foundational data structures:
1. Boxing and Unboxing (01)
2. Lists and Arrays (02, 08)
3. Collections Review (10)

### Intermediate Level
Build understanding of organized storage:
4. Dictionaries and HashTables (03, 05, 07)
5. Sets (04, 06)
6. Tuples (13)
7. Collection Interfaces (14)

### Advanced Level
Master complex structures:
8. Jagged Arrays (12)
9. Trees (15)
10. Graphs (16)
11. Heaps (17)
12. Priority Queues (18)
13. Observable Collections (09)

---

## 📊 Topics Coverage

| Category | Count | Topics |
|----------|-------|--------|
| **Basic Collections** | 5 | Lists, Arrays, ArrayList, Collections |
| **Sorted Collections** | 3 | SortedList, SortedSet, SortedDictionary |
| **Key-Value Storage** | 2 | Dictionary, HashTable |
| **Unique Storage** | 2 | HashSet, BitArray |
| **Advanced Structures** | 4 | Trees, Graphs, Heaps, Priority Queues |
| **Utilities** | 2 | Tuples, Interfaces |

**Total Projects: 99+**

---

## 🎯 Key Concepts by Topic

### Data Structure Selection
Each project demonstrates when and why to use specific structures:
- **List**: Sequential access, indexing required
- **Dictionary**: Key-value lookups
- **HashSet**: Uniqueness, membership testing
- **SortedList**: Automatic ordering with key-value pairs
- **Tree**: Hierarchical relationships
- **Graph**: Complex relationships, networks
- **Heap**: Priority-based access
- **Priority Queue**: Task scheduling, Dijkstra's algorithm

### Performance Characteristics
Includes benchmarking projects comparing:
- Insertion: O(1) average vs O(n) worst case
- Search: O(1) hash vs O(log n) tree vs O(n) linear
- Space: Overhead and memory efficiency
- Access patterns: Random vs sequential

---

## 🔧 Technologies & Patterns

### C# Features Used
- Generics and type parameters
- LINQ queries and extensions
- Delegates and events
- Interfaces and abstract classes
- Properties and auto-properties
- Tuples and deconstruction
- Collections and enumerators

### Design Patterns
- Observer pattern (ObservableCollection)
- Comparator pattern (Custom sorting)
- Iterator pattern (Enumerables)
- Strategy pattern (Different algorithms)

### Algorithms Implemented
- Binary Search Tree operations
- Graph traversal (BFS, DFS)
- Shortest path (Dijkstra's)
- Heap sort
- Tree traversal (In-order, Pre-order, Post-order)
- Union-Find connectivity

---

## 📝 Project Structure Example

Each project includes:

```csharp
/*
Description: Clear explanation of what the project demonstrates
Concepts: Key learning objectives
Use Cases: Real-world applications
*/

using System;
using System.Collections.Generic;

static class ProjectName
{
    static void Main(string[] args)
    {
        // Implementation demonstrating the concept
        // With clear variable names and comments
    }
}
```

---

## ✨ Recent Additions (Latest Update)

20 new practice projects were added to ensure comprehensive coverage:

### New Tree Projects (15_Tree)
- **03_BinarySearchTree**: Full BST implementation with search, insert, delete
- **04_TreeTraversal**: All traversal methods with complexity analysis
- **05_BalancedTrees**: AVL tree implementation with auto-balancing

### New Graph Projects (16_Graph)
- **03_GraphBFS_DFS**: Breadth-first and depth-first search
- **04_GraphShortestPath**: Dijkstra's algorithm implementation
- **05_GraphConnectivity**: Union-Find and connectivity checking

### New Priority Queue Projects (18_PriorityQueue)
- **02_PriorityQueueWithHeap**: Custom heap-based priority queue
- **03_TaskScheduler**: Real-world task scheduling application
- **04_DijkstraWithPQ**: Optimized shortest path using priority queue
- **05_MedianFinder**: Finding median in data streams

### Other New Projects
- **01_BoxingAndUnboxing**: 4 comprehensive projects on boxing scenarios
- **05_SortedList**: Custom object operations
- **09_ObservableCollection**: Data binding and advanced scenarios
- **10_DataStructuresReview**: Performance comparison benchmarks
- **12_JaggedArray**: Matrix operations
- **17_Heap**: Heap sort implementation

---

## 🤝 Contributing

This is a learning repository. Feel free to:
- Fork and create your own implementations
- Add new projects demonstrating alternative approaches
- Submit improvements and optimizations
- Report issues and suggest enhancements

---

## 📖 Resources & References

### Official Documentation
- [Microsoft Docs - Collections](https://docs.microsoft.com/en-us/dotnet/api/system.collections)
- [MSDN - Data Structures](https://msdn.microsoft.com/en-us/library/default.aspx)
- [C# Language Features](https://docs.microsoft.com/en-us/dotnet/csharp/)

### Recommended Reading
- "Introduction to Algorithms" - CLRS
- "Data Structures and Algorithms in C#" - Goodrich & Tamassia
- "CLR via C#" - Jeffrey Richter

---

## 📄 License

This repository is provided for educational purposes. Please refer to the LICENSE file for details.

---

## 👨‍💻 Author

**Mohamed Ragheb Omer**

Created as a comprehensive learning resource for advanced C# data structures.

---

## 🔗 Repository Links

- **GitHub**: [MohamedRaghebOmer/Data-Structure-Advanced-Concepts](https://github.com/MohamedRaghebOmer/Data-Structure-Advanced-Concepts)
- **Issues**: Report bugs and request features
- **Discussions**: Share ideas and solutions

---

## 📅 Last Updated

April 18, 2026

**Latest Addition**: 20 new practice projects across 9 directories bringing total to 99+ projects with comprehensive coverage of all advanced data structures.

---

## 🎓 Learning Outcomes

After completing projects in this repository, you'll understand:

✅ When to use each data structure  
✅ Time and space complexity trade-offs  
✅ Implementation details and optimization  
✅ Real-world applications and use cases  
✅ Algorithm selection and performance analysis  
✅ Advanced C# features and patterns  
✅ Professional code organization and documentation  

---

## ⭐ If You Find This Helpful

Please consider starring this repository to help others discover this comprehensive learning resource!

```
★ Star this repository
🔗 Share with others
📚 Learn and practice
💡 Contribute improvements
```

---

**Happy Learning! 🚀**
