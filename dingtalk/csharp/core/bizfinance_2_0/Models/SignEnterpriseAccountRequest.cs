// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class SignEnterpriseAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("bankCardNo")]
        [Validation(Required=false)]
        public string BankCardNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("bankOpenId")]
        [Validation(Required=false)]
        public string BankOpenId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMM_UNIONPAY</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>signed</para>
        /// </summary>
        [NameInMap("signOperateType")]
        [Validation(Required=false)]
        public string SignOperateType { get; set; }

    }

}
