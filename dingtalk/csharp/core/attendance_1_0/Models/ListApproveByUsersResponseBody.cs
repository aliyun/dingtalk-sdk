// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ListApproveByUsersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListApproveByUsersResponseBodyResult> Result { get; set; }
        public class ListApproveByUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4850378c0ee83</para>
            /// </summary>
            [NameInMap("approveId")]
            [Validation(Required=false)]
            public string ApproveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-15 AM</para>
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("calculateModel")]
            [Validation(Required=false)]
            public int? CalculateModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("durationUnit")]
            [Validation(Required=false)]
            public string DurationUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-15 AM</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>年假</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>请假</para>
            /// </summary>
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
