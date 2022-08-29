// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class SaveIntegratedInstanceRequest : TeaModel {
        [NameInMap("formComponentValueList")]
        [Validation(Required=false)]
        public List<SaveIntegratedInstanceRequestFormComponentValueList> FormComponentValueList { get; set; }
        public class SaveIntegratedInstanceRequestFormComponentValueList : TeaModel {
            /// <summary>
            /// 控件别名
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// 控件类型，取值：
            /// 
            /// TextField：单行输入框
            /// 
            /// TextareaField：多行输入框
            /// 
            /// NumberField：数字输入框
            /// 
            /// DDSelectField：单选框
            /// 
            /// DDMultiSelectField：多选框
            /// 
            /// DDDateField：日期控件
            /// 
            /// DDDateRangeField：时间区间控件
            /// 
            /// TextNote：文字说明控件
            /// 
            /// PhoneField：电话控件
            /// 
            /// DDPhotoField：图片控件
            /// 
            /// MoneyField：金额控件
            /// 
            /// TableField：明细控件
            /// 
            /// DDAttachment：附件
            /// 
            /// InnerContactField：联系人控件
            /// 
            /// RelateField：关联审批单
            /// 
            /// FormRelateField：关联控件
            /// 
            /// AddressField：省市区控件
            /// 
            /// StarRatingField：评分控件
            /// 
            /// DepartmentField：部门控件
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// 表单扩展值
            /// </summary>
            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            /// <summary>
            /// 控件id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 表单名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 表单值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("notifiers")]
        [Validation(Required=false)]
        public List<SaveIntegratedInstanceRequestNotifiers> Notifiers { get; set; }
        public class SaveIntegratedInstanceRequestNotifiers : TeaModel {
            /// <summary>
            /// 抄送位置，可以值有：
            /// start - 审批发起时，通知抄送人
            /// finish - 审批通过后，通知抄送人
            /// start_finish - 审批发起时和审批通过后，都通知抄送人
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// 抄送接收人用户ID
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        /// <summary>
        /// 审批实例接收人的userId。
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// 审批模板唯一码
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 实例标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 三方审批系统中审批单的详情页地址
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
