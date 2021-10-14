// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class AddCityCarApplyRequest : TeaModel {
        /// <summary>
        /// 出差事由
        /// </summary>
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// 用车城市
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// 第三方企业ID
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 用车时间，按天管控，比如传值2021-03-18 20:26:56表示2021-03-18当天可用车，跨天情况配合finishedDate参数使用
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// account
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// suiteKey
        /// </summary>
        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        /// <summary>
        /// tokenGrantType
        /// </summary>
        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 用车截止时间，按天管控，比如date传值2021-03-18 20:26:56、finished_date传值2021-03-30 20:26:56表示2021-03-18(含)到2021-03-30(含)之间可用车，该参数不传值情况使用date作为用车截止时间；
        /// </summary>
        [NameInMap("finishedDate")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        /// <summary>
        /// 审批单关联的项目code
        /// </summary>
        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 审批单关联的项目名
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 审批单状态：0-申请，1-同意，2-拒绝
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// 三方审批单ID
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// 审批单关联的三方成本中心ID
        /// </summary>
        [NameInMap("thirdPartCostCenterId")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// 审批单关联的三方发票抬头ID
        /// </summary>
        [NameInMap("thirdPartInvoiceId")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        /// <summary>
        /// 审批单可用总次数
        /// </summary>
        [NameInMap("timesTotal")]
        [Validation(Required=false)]
        public long? TimesTotal { get; set; }

        /// <summary>
        /// 审批单可用次数类型：1-次数不限制，2-用户可指定次数，3-管理员限制次数；如果企业没有限制审批单使用次数的需求，这个参数传1(次数不限制)，同时times_total和times_used都传0即可
        /// </summary>
        [NameInMap("timesType")]
        [Validation(Required=false)]
        public long? TimesType { get; set; }

        /// <summary>
        /// 审批单已用次数
        /// </summary>
        [NameInMap("timesUsed")]
        [Validation(Required=false)]
        public long? TimesUsed { get; set; }

        /// <summary>
        /// 审批单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 发起审批的第三方员工ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
