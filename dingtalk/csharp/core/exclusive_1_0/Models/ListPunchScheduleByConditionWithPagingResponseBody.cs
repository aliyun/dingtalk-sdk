// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListPunchScheduleByConditionWithPagingResponseBodyList> List { get; set; }
        public class ListPunchScheduleByConditionWithPagingResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>be0d84e04316488cxxxxxxxx129522b0</para>
            /// </summary>
            [NameInMap("bizOuterId")]
            [Validation(Required=false)]
            public string BizOuterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试打卡机</para>
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>checkIn</para>
            /// </summary>
            [NameInMap("punchSymbol")]
            [Validation(Required=false)]
            public string PunchSymbol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200003</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1647333408000</para>
            /// </summary>
            [NameInMap("userPunchTime")]
            [Validation(Required=false)]
            public long? UserPunchTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
