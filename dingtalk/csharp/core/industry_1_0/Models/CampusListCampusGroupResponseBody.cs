// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListCampusGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListCampusGroupResponseBodyResult> Result { get; set; }
        public class CampusListCampusGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>扩展</para>
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10101</para>
            /// </summary>
            [NameInMap("groupDeptId")]
            [Validation(Required=false)]
            public long? GroupDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试项目组</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
