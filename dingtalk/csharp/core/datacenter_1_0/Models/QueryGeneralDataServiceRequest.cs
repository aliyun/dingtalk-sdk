// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryGeneralDataServiceRequest : TeaModel {
        /// <summary>
        /// 部门ID
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// statDate
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
