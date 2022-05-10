// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreGroupsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<DigitalStoreGroupsResponseBodyContent> Content { get; set; }
        public class DigitalStoreGroupsResponseBodyContent : TeaModel {
            /// <summary>
            /// 分组Id
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// 分组名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
