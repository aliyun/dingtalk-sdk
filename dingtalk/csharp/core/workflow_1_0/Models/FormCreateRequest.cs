// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormCreateRequest : TeaModel {
        /// <summary>
        /// 表单模板描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 表单控件列表
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// 表单模板名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 模板配置信息
        /// </summary>
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
        };

    }

}
