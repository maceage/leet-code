# LeetCode Puzzles

My C# solutions to **122 LeetCode problems**, organised by algorithmic topic and covered by unit tests.

Written during an interview-preparation period when most companies were pairing LeetCode-style coding challenges with system design rounds. After twenty-plus years of writing software professionally, I was familiar with most of these data structures but rarely had a use for them in my day-to-day work – so I embarked on a journey of learning as much as I possibly could, using the excellent [NeetCode](https://www.youtube.com/@NeetCode) videos as my curriculum.

Because I wanted to treat the prep like engineering work rather than puzzle-grinding, everything lives in a proper .NET solution and everything is tested.

## Approach

**Tests for everything – every problem has a corresponding unit test using xUnit and FluentAssertions, written Arrange-Act-Assert style.**

**Topic-based organisation - problems are grouped by technique (Sliding Window, Monotonic Stack, Trie...) rather than difficulty, because recognising the pattern is the skill interviews actually test.**

**Multiple solutions where relevant – some problems keep both a naive and an optimised approach side by side, so the complexity difference can be seen rather than just claimed.**

## Statistics

| Metric          | Value                    |
|-----------------|--------------------------|
| Problems solved | 122                      |
| Topics covered  | 18                       |
| Language        | C#                       |
| Test framework  | xUnit + FluentAssertions |

## Topics

| Topic                            | Count |
|----------------------------------|-------|
| Array/String                     | 22    |
| Hash Map/Set/Sorted Set          | 17    |
| Linked List                      | 17    |
| Binary Search Tree               | 10    |
| Two Pointers                     | 10    |
| Dynamic Programming              | 8     |
| Graphs                           | 6     |
| Binary Search (Sorted Arrays)    | 4     |
| Priority Queue/Min Heap/Max Heap | 4     |
| Sliding Window                   | 4     |
| Stack                            | 4     |
| Bit Manipulation                 | 3     |
| Queue                            | 3     |
| Backtracking                     | 2     |
| Intervals                        | 2     |
| Monotonic Stack (Sorted Stack)   | 2     |
| Prefix Sum                       | 2     |
| Trie                             | 2     |

## Running the tests

    dotnet test

## Credits

The learning approach and problem selection follow the [NeetCode roadmap](https://neetcode.io/roadmap). Go watch his videos – they're the best explanation of *how to recognise* problem types that I found anywhere.

## Related writing

I wrote about this repository and the approach behind it on my blog:
[Demystifying LeetCode](https://blog.maceage.com/posts/2025/demistifying-leetcode)