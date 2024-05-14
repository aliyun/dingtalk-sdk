// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchQueryByTemplateKeyResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<BatchQueryByTemplateKeyResponseBodyTemplateList> TemplateList { get; set; }
        public class BatchQueryByTemplateKeyResponseBodyTemplateList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("adaptEnv")]
            [Validation(Required=false)]
            public List<string> AdaptEnv { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appDesc")]
            [Validation(Required=false)]
            public string AppDesc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("caseVideoList")]
            [Validation(Required=false)]
            public List<string> CaseVideoList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("coverImgList")]
            [Validation(Required=false)]
            public List<string> CoverImgList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("expUrl")]
            [Validation(Required=false)]
            public string ExpUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industryLabelList")]
            [Validation(Required=false)]
            public List<string> IndustryLabelList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("installTimes")]
            [Validation(Required=false)]
            public float? InstallTimes { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("mobilePreviewMediaList")]
            [Validation(Required=false)]
            public List<string> MobilePreviewMediaList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("previewMediaList")]
            [Validation(Required=false)]
            public List<string> PreviewMediaList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("providerName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleLabelList")]
            [Validation(Required=false)]
            public List<string> RoleLabelList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("simpleDesc")]
            [Validation(Required=false)]
            public string SimpleDesc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("useCasesMediaList")]
            [Validation(Required=false)]
            public List<string> UseCasesMediaList { get; set; }

        }

    }

}
