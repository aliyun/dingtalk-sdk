// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormCreateRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        public FormCreateRequestTemplateConfig TemplateConfig { get; set; }
        public class FormCreateRequestTemplateConfig : TeaModel {
            [NameInMap("dirId")]
            [Validation(Required=false)]
            public string DirId { get; set; }

            [NameInMap("disableDeleteProcess")]
            [Validation(Required=false)]
            public bool? DisableDeleteProcess { get; set; }

            [NameInMap("disableFormEdit")]
            [Validation(Required=false)]
            public bool? DisableFormEdit { get; set; }

            [NameInMap("disableHomepage")]
            [Validation(Required=false)]
            public bool? DisableHomepage { get; set; }

            [NameInMap("disableResubmit")]
            [Validation(Required=false)]
            public bool? DisableResubmit { get; set; }

            [NameInMap("disableStopProcessButton")]
            [Validation(Required=false)]
            public bool? DisableStopProcessButton { get; set; }

            [NameInMap("hidden")]
            [Validation(Required=false)]
            public bool? Hidden { get; set; }

            [NameInMap("originDirId")]
            [Validation(Required=false)]
            public string OriginDirId { get; set; }

        }

    }

}
