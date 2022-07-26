// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProcessRequest : TeaModel {
        /// <summary>
        /// 本次操作的行为
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// 生态唯一标识,枚举:opsoft， 需要注册
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 主数据名称
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProcessRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProcessRequestExtendData : TeaModel {
            /// <summary>
            /// 扩展字段唯一标识(英文)
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 扩展字段中文描述
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 扩展字段实际取值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// 扩展字段类型,例如string
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// 工序名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否必须派工
        /// </summary>
        [NameInMap("needDispatch")]
        [Validation(Required=false)]
        public string NeedDispatch { get; set; }

        /// <summary>
        /// 是否需要质检
        /// </summary>
        [NameInMap("needQualityTest")]
        [Validation(Required=false)]
        public string NeedQualityTest { get; set; }

        /// <summary>
        /// 工序代码
        /// </summary>
        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// 工序属性(自制/委外)
        /// </summary>
        [NameInMap("prop")]
        [Validation(Required=false)]
        public string Prop { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 操作流程
        /// </summary>
        [NameInMap("sop")]
        [Validation(Required=false)]
        public string Sop { get; set; }

        /// <summary>
        /// 工序唯一标识
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
