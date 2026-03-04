#define TEST_ENV        // 테스트 환경 심벌 정의
#undef RELEASE_ENV     // 리스 환경 심벌 해제 (만약 정의되어 있다면)

// #undef TEST_ENV     // 테스트 환경 심벌 해제 (필요시)

namespace day14_preprocessor
{
    internal class Program
    {
        #region Preprocessor Directives 
        // #region을 사용하여 변수나 속성을 따로 묶어서 접어둘 수 있다.
        public static bool IsDebugMode { get; set; } = true;
        #endregion 
        static void Main(string[] args)
        {
            // 조건부 컴파일 예시
            #region Conditional Compilation Login
#if (TEST_ENV)
            Console.WriteLine("테스트 환경입니다.");
            IsDebugMode = true;
#elif (RELEASE_ENV)
            Console.WriteLine("배포 환경입니다.");
            IsDebugMode = false;
#else
            Console.WriteLine("알 수 없는 환경입니다.");
#endif
            #endregion
            #region Pragma and Warnings
            // 2. Pragma를 이용한 경고 제어
            // 아래 코드는 절대 실행되지 않으므로 원래는 경고(CS0162)가 뜨지만, pragma로 잠시 끕니다.
#pragma warning disable
            if (false)
            {
                Console.WriteLine("이 코드는 실행되지 않지만 경고도 뜨지 않습니다.");
            }
#pragma warning restore // 다시 경고 모드 키기
            #endregion

            Console.WriteLine($"최종 디버그 상태: {IsDebugMode}");
        }
    }
}
