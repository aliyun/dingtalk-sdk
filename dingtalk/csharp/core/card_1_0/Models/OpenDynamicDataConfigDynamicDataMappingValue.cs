// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class OpenDynamicDataConfigDynamicDataMappingValue : TeaModel {
        /// <summary>
        /// jsonPath
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// 值的类型 (STRING: String, ARRAY: 数组, OBJECT: 对象, CHART: 图表, TABLE: 表格, INDICATOR: 指标卡)
        /// </summary>
        [NameInMap("dynamicDataValueType")]
        [Validation(Required=false)]
        public string DynamicDataValueType { get; set; }

    }

}
