// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormComponentProps : TeaModel {
        /// <summary>
        /// 地址控件模式city省市,district省市区,street省市区街道
        /// </summary>
        [NameInMap("addressModel")]
        [Validation(Required=false)]
        public string AddressModel { get; set; }

        /// <summary>
        /// 文字提示控件显示方式:top|middle|bottom
        /// </summary>
        [NameInMap("align")]
        [Validation(Required=false)]
        public string Align { get; set; }

        /// <summary>
        /// 套件中控件是否可设置为分条件字段
        /// </summary>
        [NameInMap("asyncCondition")]
        [Validation(Required=false)]
        public bool? AsyncCondition { get; set; }

        /// <summary>
        /// 关联审批单控件限定模板列表
        /// </summary>
        [NameInMap("availableTemplates")]
        [Validation(Required=false)]
        public List<AvaliableTemplate> AvailableTemplates { get; set; }

        /// <summary>
        /// 业务别名
        /// </summary>
        [NameInMap("bizAlias")]
        [Validation(Required=false)]
        public string BizAlias { get; set; }

        /// <summary>
        /// 套件的业务标识
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// 联系人控件是否支持多选，1多选，0单选
        /// </summary>
        [NameInMap("choice")]
        [Validation(Required=false)]
        public string Choice { get; set; }

        /// <summary>
        /// 自定义控件渲染标识
        /// </summary>
        [NameInMap("commonBizType")]
        [Validation(Required=false)]
        public string CommonBizType { get; set; }

        /// <summary>
        /// 控件表单内唯一id
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 说明文字控件内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 关联数据源配置
        /// </summary>
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public FormDataSource DataSource { get; set; }

        /// <summary>
        /// 是否不可编辑
        /// </summary>
        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 是否自动计算时长
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public bool? Duration { get; set; }

        /// <summary>
        /// 时间格式
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// 公式
        /// </summary>
        [NameInMap("formula")]
        [Validation(Required=false)]
        public string Formula { get; set; }

        /// <summary>
        /// 是否隐藏字段
        /// </summary>
        [NameInMap("invisible")]
        [Validation(Required=false)]
        public bool? Invisible { get; set; }

        /// <summary>
        /// 控件标题
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// 评分控件上限
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// 说明文字控件链接地址
        /// </summary>
        [NameInMap("link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// 部门控件是否可多选
        /// </summary>
        [NameInMap("multiple")]
        [Validation(Required=false)]
        public bool? Multiple { get; set; }

        /// <summary>
        /// 单选多选控件选项列表
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public List<SelectOption> Options { get; set; }

        /// <summary>
        /// 输入提示
        /// </summary>
        [NameInMap("placeholder")]
        [Validation(Required=false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// 字段是否可打印，1打印，0不打印，默认打印
        /// </summary>
        [NameInMap("print")]
        [Validation(Required=false)]
        public string Print { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// 明细控件数据汇总统计
        /// </summary>
        [NameInMap("statField")]
        [Validation(Required=false)]
        public List<FormComponentPropsStatField> StatField { get; set; }
        public class FormComponentPropsStatField : TeaModel {
            /// <summary>
            /// 需要统计的明细控件内子控件id
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// 子控件标题
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// 金额控件是否需要大写，1不需要大写，其他需要大写
            /// </summary>
            [NameInMap("upper")]
            [Validation(Required=false)]
            public string Upper { get; set; }

        }

        /// <summary>
        /// 明细填写方式，table（表格）、list（列表）
        /// </summary>
        [NameInMap("tableViewMode")]
        [Validation(Required=false)]
        public string TableViewMode { get; set; }

        /// <summary>
        /// 时间单位（天、小时）
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// 金额控件是否需要大写，1不需要大写，其他需要大写
        /// </summary>
        [NameInMap("upper")]
        [Validation(Required=false)]
        public string Upper { get; set; }

        /// <summary>
        /// 明细打印方式false横向，true纵向
        /// </summary>
        [NameInMap("verticalPrint")]
        [Validation(Required=false)]
        public bool? VerticalPrint { get; set; }

    }

}
