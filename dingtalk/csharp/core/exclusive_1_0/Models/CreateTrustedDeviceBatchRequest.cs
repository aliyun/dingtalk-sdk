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
            [NameInMap("macAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("macAddressList")]
        [Validation(Required=false)]
        public List<string> MacAddressList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Win</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
