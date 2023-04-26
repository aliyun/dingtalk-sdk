// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class NotifyAuthorizationResultRequest : TeaModel {
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("accountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        [NameInMap("beginTimeGMT")]
        [Validation(Required=false)]
        public long? BeginTimeGMT { get; set; }

        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("commerceType")]
        [Validation(Required=false)]
        public string CommerceType { get; set; }

        [NameInMap("commodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        [NameInMap("endTimeGMT")]
        [Validation(Required=false)]
        public long? EndTimeGMT { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("produceCode")]
        [Validation(Required=false)]
        public string ProduceCode { get; set; }

    }

}
