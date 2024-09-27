// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetInnerAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aooxxx</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaaxxxxx</para>
        /// </summary>
        [NameInMap("appSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>icon</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("ipWhiteList")]
        [Validation(Required=false)]
        public List<string> IpWhiteList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("ompLink")]
        [Validation(Required=false)]
        public string OmpLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("pcHomepageLink")]
        [Validation(Required=false)]
        public string PcHomepageLink { get; set; }

    }

}
