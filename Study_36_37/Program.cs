/*
 * using static System.Console;

public class DestructorTest
{
    // 생성자
    public DestructorTest()
    {
        WriteLine("[1] 생성");
    }
    // 메서드
    public void Run()
    {
        WriteLine("[2] 실행");
    }
    // 소멸자: GC
    ~DestructorTest()
    {
        WriteLine("[3] 소멸");
    }
}

class ConstructorToDestructor
{
    static void Main()
    {
        DestructorTest test = new DestructorTest(); // 생성
        test.Run(); // 실행
        // GC.Collect(); // 소멸
        //닷넷 코어로 실행되지 않고 종료
    }
}
*/

/*
using System;

class ParameterRef
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}"); // [1] 10

        Do(ref num); // 참조 전달 방식 

        Console.WriteLine($"[3] {num}"); // [3] 20
    }

    static void Do(ref int num)
    {
        num = 20; // [A] 호출한 부분에 적용(Main 메서드의 num 변수의 값이 변경됨)
        Console.WriteLine($"[2] {num}"); // [2] 20
    }
}
*/

/*
using System;

class ParameterOut
{
    static void Main()
    {
        int num; // [A] 변수를 반드시 초기화할 필요없음

        Do(out num); // 반환형 매개 변수 전달 방식 

        Console.WriteLine($"[2] {num}"); // [2] 1234
    }

    static void Do(out int num)
    {
        num = 1234; // [B] ref와 동일: 호출한 부분에 적용, 반드시 초기화해야 함
        Console.WriteLine($"[1] {num}"); // [1] 1234
    }
}
*/

/*
using System;

class ParamsDemo
{
    static void Main()
    {
        // 가변 길이 매개 변수 => params
        Console.WriteLine(SumAll(3, 5)); // 8
        Console.WriteLine(SumAll(3, 5, 7)); // 15
        Console.WriteLine(SumAll(3, 5, 7, 9)); // 24
    }

    /// <summary>
    /// SumAll() 메서드는 정수 형식의 값을 가변 형식으로 받을 수 있음
    /// </summary>
    /// <param name="numbers">정수 배열</param>
    /// <returns>정수 배열의 합계</returns>
    static int SumAll(params int[] numbers) // [1] params로 여러 개의 매개 변수 받기 
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
*/

using System;

class ParameterParams
{
    static void Main()
    {
        Console.WriteLine("가변형 매개 변수");
        Say();
        Say("안녕하세요.");
        Say("안녕하세요.", "반갑습니다.");
        string[] messages = { "Hi", "Hello" };
        Say(messages);
    }

    static void Say(params string[] messages)
    {
        foreach (var message in messages)
        {
            Console.Write($"{message}\t"); // 넘어온 메시지 출력
        }
        Console.WriteLine(); // 줄바꿈
    }
}
