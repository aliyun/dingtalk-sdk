// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class ExecuteActivityRequest : TeaModel {
        /// <summary>
        /// 动作编码
        /// </summary>
        [NameInMap("activityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// 会员名称
        /// </summary>
        [NameInMap("foreignName")]
        [Validation(Required=false)]
        public string ForeignName { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("openInstanceId")]
        [Validation(Required=false)]
        public string OpenInstanceId { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [NameInMap("productionType")]
        [Validation(Required=false)]
        public int? ProductionType { get; set; }

        /// <summary>
        /// 工单表单字段
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<ExecuteActivityRequestProperties> Properties { get; set; }
        public class ExecuteActivityRequestProperties : TeaModel {
            /// <summary>
            /// 字段的key
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 字段的值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 来源ID
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
