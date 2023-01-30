// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetDoubleRandomResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// InspectPlanId:抽查计划编号
        /// InspectPlanName:抽查计划名称
        /// InspectTaskId:抽查任务编号
        /// InspectTaskName:抽查任务名称
        /// InspectTypeName:抽查类型
        /// InspectDepartment:抽查机关
        /// InspectDate:抽查完成时间
        /// InspectItem:检查事项
        /// InspectResult:检查结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
