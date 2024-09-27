// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class CreateInnerAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>descxxx</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("developType")]
        [Validation(Required=false)]
        public int? DevelopType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("homepageLink")]
        [Validation(Required=false)]
        public string HomepageLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mediaxxx</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("ipWhiteList")]
        [Validation(Required=false)]
        public List<string> IpWhiteList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namexx</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("pcHomepageLink")]
        [Validation(Required=false)]
        public string PcHomepageLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BASE</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
