// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeRequest : TeaModel {
        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 是否包含节假日
        /// </summary>
        [NameInMap("includesHolidays")]
        [Validation(Required=false)]
        public bool? IncludesHolidays { get; set; }

        /// <summary>
        /// 是否连续
        /// </summary>
        [NameInMap("isDuration")]
        [Validation(Required=false)]
        public bool? IsDuration { get; set; }

        /// <summary>
        /// 对象 ID，比如 任务 ID
        /// </summary>
        [NameInMap("objectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象类型，默认为 task
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 操作者用户id
        /// </summary>
        [NameInMap("optUser")]
        [Validation(Required=false)]
        public string OptUser { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 工时提交人员用户id
        /// </summary>
        [NameInMap("submitterId")]
        [Validation(Required=false)]
        public string SubmitterId { get; set; }

        /// <summary>
        /// 实际工时数（单位毫秒，1小时即为3600000）
        /// </summary>
        [NameInMap("workTime")]
        [Validation(Required=false)]
        public long? WorkTime { get; set; }

        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

    }

}
