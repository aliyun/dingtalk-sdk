// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateJobDeliverRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channelOuterId</para>
        /// </summary>
        [NameInMap("channelOuterId")]
        [Validation(Required=false)]
        public string ChannelOuterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27016066248xxxxx</para>
        /// </summary>
        [NameInMap("deliverUserId")]
        [Validation(Required=false)]
        public string DeliverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ATS001</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>职位审核不通过</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666780239981</para>
        /// </summary>
        [NameInMap("opTime")]
        [Validation(Required=false)]
        public long? OpTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27016066248xxxxx</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobId23ed0d46548f4e88a7b808d3f3057xxx</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
