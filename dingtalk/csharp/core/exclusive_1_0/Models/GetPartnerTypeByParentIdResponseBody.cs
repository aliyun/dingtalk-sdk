// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPartnerTypeByParentIdResponseBody : TeaModel {
        /// <summary>
        /// 子标签列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPartnerTypeByParentIdResponseBodyData> Data { get; set; }
        public class GetPartnerTypeByParentIdResponseBodyData : TeaModel {
            /// <summary>
            /// 自标签id
            /// </summary>
            [NameInMap("typeId")]
            [Validation(Required=false)]
            public float? TypeId { get; set; }

            /// <summary>
            /// 子标签名
            /// </summary>
            [NameInMap("typeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
