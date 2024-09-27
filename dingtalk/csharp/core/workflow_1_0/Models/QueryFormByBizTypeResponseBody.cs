// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryFormByBizTypeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryFormByBizTypeResponseBodyResult> Result { get; set; }
        public class QueryFormByBizTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>应用类型</para>
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SWAPP-abcdef-example</para>
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>表单业务标识</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1635151039000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02501234567890</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROC-abcdef-example</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FORM-example</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用于收集休假信息</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1635151039000</para>
            /// </summary>
            [NameInMap("modifedTime")]
            [Validation(Required=false)]
            public long? ModifedTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>休假申请</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02501234567890</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED(启用), INVALID(停用), SAVED(草稿)</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
