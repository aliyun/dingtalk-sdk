// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetAllSheetsResponseBody : TeaModel {
        /// <summary>
        /// 所有工作表信息
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<GetAllSheetsResponseBodyValue> Value { get; set; }
        public class GetAllSheetsResponseBodyValue : TeaModel {
            /// <summary>
            /// 工作表ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 工作表名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
