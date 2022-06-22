// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusUpdateRenterRequest : TeaModel {
        /// <summary>
        /// 企业信用代码
        /// </summary>
        [NameInMap("creditCode")]
        [Validation(Required=false)]
        public string CreditCode { get; set; }

        /// <summary>
        /// 租期开始时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// 租客名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 租客ID
        /// </summary>
        [NameInMap("renterId")]
        [Validation(Required=false)]
        public long? RenterId { get; set; }

        /// <summary>
        /// 租期结束时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
