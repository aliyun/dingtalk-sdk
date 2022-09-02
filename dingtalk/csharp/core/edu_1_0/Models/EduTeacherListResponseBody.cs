// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduTeacherListResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public EduTeacherListResponseBodyResult Result { get; set; }
        public class EduTeacherListResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否还有下一页
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 教师信息
            /// </summary>
            [NameInMap("teacherDetails")]
            [Validation(Required=false)]
            public List<EduTeacherListResponseBodyResultTeacherDetails> TeacherDetails { get; set; }
            public class EduTeacherListResponseBodyResultTeacherDetails : TeaModel {
                /// <summary>
                /// 用户名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 角色
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// PiiiPyQqBxxx
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// 用户ID
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
