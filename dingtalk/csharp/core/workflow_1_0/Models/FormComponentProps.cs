// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormComponentProps : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>增加明细</para>
        /// </summary>
        [NameInMap("actionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("addressModel")]
        [Validation(Required=false)]
        public string AddressModel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>top</para>
        /// </summary>
        [NameInMap("align")]
        [Validation(Required=false)]
        public string Align { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asyncCondition")]
        [Validation(Required=false)]
        public bool? AsyncCondition { get; set; }

        [NameInMap("availableTemplates")]
        [Validation(Required=false)]
        public List<AvaliableTemplate> AvailableTemplates { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>finance_name</para>
        /// </summary>
        [NameInMap("bizAlias")]
        [Validation(Required=false)]
        public string BizAlias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>attendance.leave</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("choice")]
        [Validation(Required=false)]
        public string Choice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom_view</para>
        /// </summary>
        [NameInMap("commonBizType")]
        [Validation(Required=false)]
        public string CommonBizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TextField-abcd</para>
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我是说明文字控件</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public FormDataSource DataSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public bool? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>时长</para>
        /// </summary>
        [NameInMap("durationLabel")]
        [Validation(Required=false)]
        public string DurationLabel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("formula")]
        [Validation(Required=false)]
        public string Formula { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("invisible")]
        [Validation(Required=false)]
        public bool? Invisible { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>姓名</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www">http://www</a>.</para>
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>phone_tel</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("multiple")]
        [Validation(Required=false)]
        public bool? Multiple { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public List<SelectOption> Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请输入</para>
        /// </summary>
        [NameInMap("placeholder")]
        [Validation(Required=false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("precision")]
        [Validation(Required=false)]
        public int? Precision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("print")]
        [Validation(Required=false)]
        public string Print { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("statField")]
        [Validation(Required=false)]
        public List<FormComponentPropsStatField> StatField { get; set; }
        public class FormComponentPropsStatField : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NumberField-abcd</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>金额</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("upper")]
            [Validation(Required=false)]
            public string Upper { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("tableViewMode")]
        [Validation(Required=false)]
        public string TableViewMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>天</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("upper")]
        [Validation(Required=false)]
        public string Upper { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("verticalPrint")]
        [Validation(Required=false)]
        public bool? VerticalPrint { get; set; }

    }

}
