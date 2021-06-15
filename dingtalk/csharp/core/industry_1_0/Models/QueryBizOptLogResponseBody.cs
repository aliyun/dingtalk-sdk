// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryBizOptLogResponseBody : TeaModel {
        /// <summary>
        /// content
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryBizOptLogResponseBodyContent> Content { get; set; }
        public class QueryBizOptLogResponseBodyContent : TeaModel {
            /// <summary>
            /// 日志ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 数据类型
            /// </summary>
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// 业务类型
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// 操作时间 时间戳
            /// </summary>
            [NameInMap("optTime")]
            [Validation(Required=false)]
            public long? OptTime { get; set; }

            /// <summary>
            /// 操作用户code
            /// </summary>
            [NameInMap("optUserCode")]
            [Validation(Required=false)]
            public string OptUserCode { get; set; }

            /// <summary>
            /// 操作用户名称
            /// </summary>
            [NameInMap("optUserName")]
            [Validation(Required=false)]
            public string OptUserName { get; set; }

            /// <summary>
            /// 操作者工号
            /// </summary>
            [NameInMap("optJobNumber")]
            [Validation(Required=false)]
            public string OptJobNumber { get; set; }

            /// <summary>
            /// 操作类型
            /// </summary>
            [NameInMap("optType")]
            [Validation(Required=false)]
            public int? OptType { get; set; }

            /// <summary>
            /// 操作业务类型
            /// </summary>
            [NameInMap("optBizType")]
            [Validation(Required=false)]
            public int? OptBizType { get; set; }

            /// <summary>
            /// 操作对象code，人员code，或者部门code
            /// </summary>
            [NameInMap("optObjectCode")]
            [Validation(Required=false)]
            public string OptObjectCode { get; set; }

            /// <summary>
            /// 操作对象人员工号
            /// </summary>
            [NameInMap("optObjectUserJobNo")]
            [Validation(Required=false)]
            public string OptObjectUserJobNo { get; set; }

            /// <summary>
            /// 操作对象名称
            /// </summary>
            [NameInMap("optObjectName")]
            [Validation(Required=false)]
            public string OptObjectName { get; set; }

            /// <summary>
            /// 操作是否成功
            /// </summary>
            [NameInMap("optSuccess")]
            [Validation(Required=false)]
            public int? OptSuccess { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 操作前对象数据快照，json格式
            /// </summary>
            [NameInMap("optBeforeData")]
            [Validation(Required=false)]
            public string OptBeforeData { get; set; }

            /// <summary>
            /// 操作后对象数据快照，json格式
            /// </summary>
            [NameInMap("optAfterData")]
            [Validation(Required=false)]
            public string OptAfterData { get; set; }

            /// <summary>
            /// 扩展信息，map json格式
            /// </summary>
            [NameInMap("optExtend")]
            [Validation(Required=false)]
            public string OptExtend { get; set; }

        }

        /// <summary>
        /// 下次拉取数据的起始位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
