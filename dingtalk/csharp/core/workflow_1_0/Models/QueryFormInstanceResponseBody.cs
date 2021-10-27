// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryFormInstanceResponseBody : TeaModel {
        /// <summary>
        /// 应用搭建id
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// 实例创建时间戳
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// 表单模板id
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// 表单数据
        /// </summary>
        [NameInMap("formInstDataList")]
        [Validation(Required=false)]
        public List<QueryFormInstanceResponseBodyFormInstDataList> FormInstDataList { get; set; }
        public class QueryFormInstanceResponseBodyFormInstDataList : TeaModel {
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            [NameInMap("extendValue")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("formInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// 实例最近修改时间戳
        /// </summary>
        [NameInMap("modifyTimestamp")]
        [Validation(Required=false)]
        public long? ModifyTimestamp { get; set; }

        /// <summary>
        /// 外联业务code
        /// </summary>
        [NameInMap("outBizCode")]
        [Validation(Required=false)]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 外联业务实例id
        /// </summary>
        [NameInMap("outInstanceId")]
        [Validation(Required=false)]
        public string OutInstanceId { get; set; }

        /// <summary>
        /// 表单标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
