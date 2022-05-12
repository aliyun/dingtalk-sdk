// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class SendCardRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("deviceUuid")]
        [Validation(Required=false)]
        public string DeviceUuid { get; set; }

        [NameInMap("encodeCid")]
        [Validation(Required=false)]
        public string EncodeCid { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
