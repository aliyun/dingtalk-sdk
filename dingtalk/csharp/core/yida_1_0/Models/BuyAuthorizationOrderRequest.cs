// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BuyAuthorizationOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hexaaaa</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("accountNumber")]
        [Validation(Required=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234123423459</para>
        /// </summary>
        [NameInMap("beginTimeGMT")]
        [Validation(Required=false)]
        public long? BeginTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44234122</para>
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>subscribe</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>subscribe</para>
        /// </summary>
        [NameInMap("commerceType")]
        [Validation(Required=false)]
        public string CommerceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Business</para>
        /// </summary>
        [NameInMap("commodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1023451234123</para>
        /// </summary>
        [NameInMap("endTimeGMT")]
        [Validation(Required=false)]
        public long? EndTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A发起的实例</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yun-1234</para>
        /// </summary>
        [NameInMap("produceCode")]
        [Validation(Required=false)]
        public string ProduceCode { get; set; }

    }

}
