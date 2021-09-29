// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class UpdateCloudAccountInformationRequest : TeaModel {
        /// <summary>
        /// 访问秘钥
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 调用者unionId
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [NameInMap("accountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [NameInMap("commodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

    }

}
