// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchQueryByTemplateKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<BatchQueryByTemplateKeyResponseBodyTemplateList> TemplateList { get; set; }
        public class BatchQueryByTemplateKeyResponseBodyTemplateList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("adaptEnv")]
            [Validation(Required=false)]
            public List<string> AdaptEnv { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用</para>
            /// </summary>
            [NameInMap("appDesc")]
            [Validation(Required=false)]
            public string AppDesc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@lALPDe7s2JOuoyjNBaDNCgA</para>
            /// </summary>
            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("caseVideoList")]
            [Validation(Required=false)]
            public List<string> CaseVideoList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_category</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("coverImgList")]
            [Validation(Required=false)]
            public List<string> CoverImgList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.baidu.com">http://www.baidu.com</a></para>
            /// </summary>
            [NameInMap("expUrl")]
            [Validation(Required=false)]
            public string ExpUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("industryLabelList")]
            [Validation(Required=false)]
            public List<string> IndustryLabelList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("installTimes")]
            [Validation(Required=false)]
            public float? InstallTimes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("mobilePreviewMediaList")]
            [Validation(Required=false)]
            public List<string> MobilePreviewMediaList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("previewMediaList")]
            [Validation(Required=false)]
            public List<string> PreviewMediaList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小明</para>
            /// </summary>
            [NameInMap("providerName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("roleLabelList")]
            [Validation(Required=false)]
            public List<string> RoleLabelList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用</para>
            /// </summary>
            [NameInMap("simpleDesc")]
            [Validation(Required=false)]
            public string SimpleDesc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_key</para>
            /// </summary>
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("useCasesMediaList")]
            [Validation(Required=false)]
            public List<string> UseCasesMediaList { get; set; }

        }

    }

}
