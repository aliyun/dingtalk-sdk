// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SearchTeachersResponseBody : TeaModel {
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<SearchTeachersResponseBodyUsers> Users { get; set; }
        public class SearchTeachersResponseBodyUsers : TeaModel {
            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 所在其中一个班级ID
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// 所在其中一个班级名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

        }

    }

}
