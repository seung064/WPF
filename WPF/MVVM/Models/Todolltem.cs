﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    // [1] 데이터 모델 작성: 할 일 하나를 표현하는 객체
    // 화면에 표시할 텍스트를 담는 단순한 클래스
    public class TodoItem
    {
        public string Task { get; set; } // 할 일 문자열

        // ListBox에 객체가 표시가 될 때 이 문자열이 사용됨.
        public override string ToString() => Task;
    }
}