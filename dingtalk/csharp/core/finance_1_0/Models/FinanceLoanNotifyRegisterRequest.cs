// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class FinanceLoanNotifyRegisterRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-18 14:53:33</para>
        /// </summary>
        [NameInMap("completeTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>330725189509101234</para>
        /// </summary>
        [NameInMap("idCardNo")]
        [Validation(Required=false)]
        public string IdCardNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中原消费金融</para>
        /// </summary>
        [NameInMap("openChannelName")]
        [Validation(Required=false)]
        public string OpenChannelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XFD201909210001</para>
        /// </summary>
        [NameInMap("openProductCode")]
        [Validation(Required=false)]
        public string OpenProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>员工贷</para>
        /// </summary>
        [NameInMap("openProductName")]
        [Validation(Required=false)]
        public string OpenProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZYXJ_XFD</para>
        /// </summary>
        [NameInMap("openProductType")]
        [Validation(Required=false)]
        public string OpenProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("processingStatus")]
        [Validation(Required=false)]
        public string ProcessingStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZRSB2020</para>
        /// </summary>
        [NameInMap("refuseCode")]
        [Validation(Required=false)]
        public string RefuseCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>进件准入失败</para>
        /// </summary>
        [NameInMap("refuseReason")]
        [Validation(Required=false)]
        public string RefuseReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024061814654041710801</para>
        /// </summary>
        [NameInMap("registerNo")]
        [Validation(Required=false)]
        public string RegisterNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-06-18 14:53:33</para>
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18092149430</para>
        /// </summary>
        [NameInMap("userMobile")]
        [Validation(Required=false)]
        public string UserMobile { get; set; }

    }

}
