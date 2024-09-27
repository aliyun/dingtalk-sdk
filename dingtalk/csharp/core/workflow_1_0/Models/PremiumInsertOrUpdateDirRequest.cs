// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumInsertOrUpdateDirRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>administeration</para>
        /// </summary>
        [NameInMap("bizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分组描述信息</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>行政管理</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;en_US&quot;:&quot;test&quot;,&quot;ja_JP&quot;:&quot;test&quot;,&quot;vi_VN&quot;:&quot;test&quot;,&quot;zh_CN&quot;:&quot;测试&quot;,&quot;zh_HK&quot;:&quot;测试&quot;,&quot;zh_TW&quot;:&quot;测试&quot;}</para>
        /// </summary>
        [NameInMap("name18n")]
        [Validation(Required=false)]
        public string Name18n { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user001</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

    }

}
