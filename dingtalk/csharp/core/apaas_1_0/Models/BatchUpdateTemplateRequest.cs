// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchUpdateTemplateRequest : TeaModel {
        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<BatchUpdateTemplateRequestTemplateList> TemplateList { get; set; }
        public class BatchUpdateTemplateRequestTemplateList : TeaModel {
            /// <summary>
            /// category
            /// </summary>
            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// mobilePreviewMediaList
            /// </summary>
            [NameInMap("mobilePreviewMediaList")]
            [Validation(Required=false)]
            public List<string> MobilePreviewMediaList { get; set; }

            /// <summary>
            /// templateKey
            /// </summary>
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            /// <summary>
            /// adaptEnv
            /// </summary>
            [NameInMap("adaptEnv")]
            [Validation(Required=false)]
            public List<string> AdaptEnv { get; set; }

            /// <summary>
            /// appDesc
            /// </summary>
            [NameInMap("appDesc")]
            [Validation(Required=false)]
            public string AppDesc { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// providerName
            /// </summary>
            [NameInMap("providerName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// coverImgList
            /// </summary>
            [NameInMap("coverImgList")]
            [Validation(Required=false)]
            public List<string> CoverImgList { get; set; }

            /// <summary>
            /// roleLabelList
            /// </summary>
            [NameInMap("roleLabelList")]
            [Validation(Required=false)]
            public List<string> RoleLabelList { get; set; }

            /// <summary>
            /// previewMediaList
            /// </summary>
            [NameInMap("previewMediaList")]
            [Validation(Required=false)]
            public List<string> PreviewMediaList { get; set; }

            /// <summary>
            /// simpleDesc
            /// </summary>
            [NameInMap("simpleDesc")]
            [Validation(Required=false)]
            public string SimpleDesc { get; set; }

            /// <summary>
            /// caseVideoList
            /// </summary>
            [NameInMap("caseVideoList")]
            [Validation(Required=false)]
            public List<string> CaseVideoList { get; set; }

            /// <summary>
            /// industryLabelList
            /// </summary>
            [NameInMap("industryLabelList")]
            [Validation(Required=false)]
            public List<string> IndustryLabelList { get; set; }

            /// <summary>
            /// appIcon
            /// </summary>
            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            /// <summary>
            /// useCasesMediaList
            /// </summary>
            [NameInMap("useCasesMediaList")]
            [Validation(Required=false)]
            public List<string> UseCasesMediaList { get; set; }

            /// <summary>
            /// expUrl
            /// </summary>
            [NameInMap("expUrl")]
            [Validation(Required=false)]
            public string ExpUrl { get; set; }

        }

    }

}
