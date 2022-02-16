// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchQueryByTemplateKeyResponseBody : TeaModel {
        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<BatchQueryByTemplateKeyResponseBodyTemplateList> TemplateList { get; set; }
        public class BatchQueryByTemplateKeyResponseBodyTemplateList : TeaModel {
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("simpleDesc")]
            [Validation(Required=false)]
            public string SimpleDesc { get; set; }

            [NameInMap("appDesc")]
            [Validation(Required=false)]
            public string AppDesc { get; set; }

            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("providerName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            [NameInMap("installTimes")]
            [Validation(Required=false)]
            public float? InstallTimes { get; set; }

            [NameInMap("industryLabelList")]
            [Validation(Required=false)]
            public List<string> IndustryLabelList { get; set; }

            [NameInMap("roleLabelList")]
            [Validation(Required=false)]
            public List<string> RoleLabelList { get; set; }

            [NameInMap("adaptEnv")]
            [Validation(Required=false)]
            public List<string> AdaptEnv { get; set; }

            [NameInMap("expUrl")]
            [Validation(Required=false)]
            public string ExpUrl { get; set; }

            [NameInMap("previewMediaList")]
            [Validation(Required=false)]
            public List<string> PreviewMediaList { get; set; }

            [NameInMap("mobilePreviewMediaList")]
            [Validation(Required=false)]
            public List<string> MobilePreviewMediaList { get; set; }

            [NameInMap("useCasesMediaList")]
            [Validation(Required=false)]
            public List<string> UseCasesMediaList { get; set; }

            [NameInMap("coverImgList")]
            [Validation(Required=false)]
            public List<string> CoverImgList { get; set; }

            [NameInMap("caseVideoList")]
            [Validation(Required=false)]
            public List<string> CaseVideoList { get; set; }

        }

    }

}
