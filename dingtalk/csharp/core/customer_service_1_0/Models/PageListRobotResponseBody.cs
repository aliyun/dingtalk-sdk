// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListRobotResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListRobotResponseBodyList> List { get; set; }
        public class PageListRobotResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>32001</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>U1xup2nKKQ9zwXynjpAHVDOD</para>
            /// </summary>
            [NameInMap("appKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62703378</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试的机器人</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
