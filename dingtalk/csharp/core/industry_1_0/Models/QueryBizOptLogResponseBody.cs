// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryBizOptLogResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryBizOptLogResponseBodyContent> Content { get; set; }
        public class QueryBizOptLogResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>固定值 1-医疗组</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1-钉钉数据，2-自建数据</para>
            /// </summary>
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23821</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("optAfterData")]
            [Validation(Required=false)]
            public string OptAfterData { get; set; }

            [NameInMap("optBeforeData")]
            [Validation(Required=false)]
            public string OptBeforeData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1-人员，2-部门</para>
            /// </summary>
            [NameInMap("optBizType")]
            [Validation(Required=false)]
            public int? OptBizType { get; set; }

            [NameInMap("optExtend")]
            [Validation(Required=false)]
            public string OptExtend { get; set; }

            [NameInMap("optJobNumber")]
            [Validation(Required=false)]
            public string OptJobNumber { get; set; }

            [NameInMap("optObjectCode")]
            [Validation(Required=false)]
            public string OptObjectCode { get; set; }

            [NameInMap("optObjectName")]
            [Validation(Required=false)]
            public string OptObjectName { get; set; }

            [NameInMap("optObjectUserJobNo")]
            [Validation(Required=false)]
            public string OptObjectUserJobNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1-成功，2-失败</para>
            /// </summary>
            [NameInMap("optSuccess")]
            [Validation(Required=false)]
            public int? OptSuccess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1622191102012</para>
            /// </summary>
            [NameInMap("optTime")]
            [Validation(Required=false)]
            public long? OptTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0-删除，1-添加，2-修改，3-作废</para>
            /// </summary>
            [NameInMap("optType")]
            [Validation(Required=false)]
            public int? OptType { get; set; }

            [NameInMap("optUserCode")]
            [Validation(Required=false)]
            public string OptUserCode { get; set; }

            [NameInMap("optUserName")]
            [Validation(Required=false)]
            public string OptUserName { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
