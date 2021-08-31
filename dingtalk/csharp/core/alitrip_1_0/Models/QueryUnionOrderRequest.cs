// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryUnionOrderRequest : TeaModel {
        /// <summary>
        /// 第三方企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 第三方申请单id
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// 关联单号
        /// </summary>
        [NameInMap("unionNo")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

    }

}
