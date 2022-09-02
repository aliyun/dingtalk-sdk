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
            /// <summary>
            /// 自定义通讯录Code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 自定义通讯录名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 在自定义通讯录列表中的排序
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// 根部们Id
            /// </summary>
            [NameInMap("rootDeptId")]
            [Validation(Required=false)]
            public long? RootDeptId { get; set; }

        }

    }

}
