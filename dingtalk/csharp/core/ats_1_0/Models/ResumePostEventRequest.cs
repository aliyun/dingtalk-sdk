// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class ResumePostEventRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("candidateName")]
        [Validation(Required=false)]
        public string CandidateName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>总裁助理</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("jobOwnerUserId")]
        [Validation(Required=false)]
        public string JobOwnerUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("mobileResumeUrl")]
        [Validation(Required=false)]
        public string MobileResumeUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("pcResumeUrl")]
        [Validation(Required=false)]
        public string PcResumeUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3年 | 本科</para>
        /// </summary>
        [NameInMap("resumeDesc")]
        [Validation(Required=false)]
        public string ResumeDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resumePostTime")]
        [Validation(Required=false)]
        public long? ResumePostTime { get; set; }

    }

}
