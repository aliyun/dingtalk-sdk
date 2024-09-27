// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ListWorkBenchGroupResponseBody : TeaModel {
        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<ListWorkBenchGroupResponseBodyGroupList> GroupList { get; set; }
        public class ListWorkBenchGroupResponseBodyGroupList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
