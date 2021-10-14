// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BuyFreshOrderRequest : TeaModel {
        /// <summary>
        /// 访问秘钥
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [NameInMap("accountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("beginTimeGMT")]
        [Validation(Required=false)]
        public long? BeginTimeGMT { get; set; }

        /// <summary>
        /// 调用者unionId
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// 商业类型
        /// </summary>
        [NameInMap("commerceType")]
        [Validation(Required=false)]
        public string CommerceType { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [NameInMap("commodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endTimeGMT")]
        [Validation(Required=false)]
        public long? EndTimeGMT { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 阿里云产品码
        /// </summary>
        [NameInMap("produceCode")]
        [Validation(Required=false)]
        public string ProduceCode { get; set; }

    }

}
