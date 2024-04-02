// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormComponentProps : TeaModel {
        [NameInMap("actionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("addressModel")]
        [Validation(Required=false)]
        public string AddressModel { get; set; }

        [NameInMap("align")]
        [Validation(Required=false)]
        public string Align { get; set; }

        [NameInMap("asyncCondition")]
        [Validation(Required=false)]
        public bool? AsyncCondition { get; set; }

        [NameInMap("availableTemplates")]
        [Validation(Required=false)]
        public List<AvaliableTemplate> AvailableTemplates { get; set; }

        [NameInMap("bizAlias")]
        [Validation(Required=false)]
        public string BizAlias { get; set; }

        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("choice")]
        [Validation(Required=false)]
        public string Choice { get; set; }

        [NameInMap("commonBizType")]
        [Validation(Required=false)]
        public string CommonBizType { get; set; }

        [NameInMap("componentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public FormDataSource DataSource { get; set; }

        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public bool? Duration { get; set; }

        [NameInMap("durationLabel")]
        [Validation(Required=false)]
        public string DurationLabel { get; set; }

        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("formula")]
        [Validation(Required=false)]
        public string Formula { get; set; }

        [NameInMap("invisible")]
        [Validation(Required=false)]
        public bool? Invisible { get; set; }

        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        [NameInMap("maxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("multiple")]
        [Validation(Required=false)]
        public bool? Multiple { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public List<SelectOption> Options { get; set; }

        [NameInMap("placeholder")]
        [Validation(Required=false)]
        public string Placeholder { get; set; }

        [NameInMap("precision")]
        [Validation(Required=false)]
        public int? Precision { get; set; }

        [NameInMap("print")]
        [Validation(Required=false)]
        public string Print { get; set; }

        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("statField")]
        [Validation(Required=false)]
        public List<FormComponentPropsStatField> StatField { get; set; }
        public class FormComponentPropsStatField : TeaModel {
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("upper")]
            [Validation(Required=false)]
            public string Upper { get; set; }

        }

        [NameInMap("tableViewMode")]
        [Validation(Required=false)]
        public string TableViewMode { get; set; }

        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("upper")]
        [Validation(Required=false)]
        public string Upper { get; set; }

        [NameInMap("verticalPrint")]
        [Validation(Required=false)]
        public bool? VerticalPrint { get; set; }

    }

}
