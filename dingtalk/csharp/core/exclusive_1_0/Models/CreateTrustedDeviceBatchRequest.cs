// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateTrustedDeviceBatchRequest : TeaModel {
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<CreateTrustedDeviceBatchRequestDetailList> DetailList { get; set; }
        public class CreateTrustedDeviceBatchRequestDetailList : TeaModel {
            [NameInMap("did")]
            [Validation(Required=false)]
            public string Did { get; set; }

            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("macAddressList")]
        [Validation(Required=false)]
        public List<string> MacAddressList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Win</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
