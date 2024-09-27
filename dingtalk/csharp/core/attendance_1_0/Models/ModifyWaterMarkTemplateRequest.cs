// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ModifyWaterMarkTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-292988B1-5064-4A42-9389-A76B97xxxxx</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xx.xx.png">https://xx.xx.png</a></para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>industry_dx_xx</para>
        /// </summary>
        [NameInMap("layoutDesignId")]
        [Validation(Required=false)]
        public string LayoutDesignId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;items&quot;:[ { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;enableModifyPlace&quot;, &quot;id&quot;:&quot;enableModifyPlace-undefined&quot;, &quot;value&quot;:&quot;true&quot; } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;modifyPlaceDistance&quot;, &quot;id&quot;:&quot;modifyPlaceDistance-undefined&quot;, &quot;value&quot;:200 } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;title&quot;, &quot;id&quot;:&quot;title-undefined&quot;, &quot;value&quot;:&quot;wofu1&quot; } }, { &quot;componentName&quot;:&quot;HiddenField&quot;, &quot;props&quot;:{ &quot;bizAlias&quot;:&quot;titleBgColor&quot;, &quot;id&quot;:&quot;titleBgColor-undefined&quot;, &quot;value&quot;:&quot;#0089FF&quot; } } ] }</para>
        /// </summary>
        [NameInMap("schemaContent")]
        [Validation(Required=false)]
        public string SchemaContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-292988B1-5064-4A42-9389-A76B97xxxxx</para>
        /// </summary>
        [NameInMap("waterMarkId")]
        [Validation(Required=false)]
        public string WaterMarkId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manage123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
