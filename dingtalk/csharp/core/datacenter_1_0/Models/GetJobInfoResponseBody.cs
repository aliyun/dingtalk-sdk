// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// EntName:企业名称
        /// RecruitingName:职位
        /// Description:描述
        /// Salary:薪资
        /// RecruitingAddress:公司地点
        /// Education:学历
        /// Experience:工作经验
        /// BenefitList:福利
        /// PublishDate:发布日期
        /// StartDate:招聘开始日期
        /// EndDate:招聘截止日期
        /// PageUrl:数据源链接
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
