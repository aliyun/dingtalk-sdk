// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactCreateResponseBody : TeaModel {
        /// <summary>
        /// 自定义通讯录信息
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public CustomizeContactCreateResponseBodyContent Content { get; set; }
        public class CustomizeContactCreateResponseBodyContent : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }
            [NameInMap("rootDeptId")]
            [Validation(Required=false)]
            public long? RootDeptId { get; set; }
        };

    }

}
