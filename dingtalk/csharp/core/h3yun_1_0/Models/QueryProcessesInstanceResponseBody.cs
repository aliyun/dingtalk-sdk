// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryProcessesInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryProcessesInstanceResponseBodyData> Data { get; set; }
        public class QueryProcessesInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>D000183D000185</para>
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>006f870b-4d1c-4cd0-85b3-2e866798e947</para>
            /// </summary>
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-19 19:36:54</para>
            /// </summary>
            [NameInMap("createdTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("dingTalkProcessId")]
            [Validation(Required=false)]
            public string DingTalkProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public QueryProcessesInstanceResponseBodyDataOriginator Originator { get; set; }
            public class QueryProcessesInstanceResponseBodyDataOriginator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>18f923a7-5a5e-426d-94ae-a55ad1a4b240</para>
                /// </summary>
                [NameInMap("departmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>研发中心</para>
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aea4d7a7-d162-4c77-9c44-7bd9cb8316a5</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>报销管理</para>
            /// </summary>
            [NameInMap("processDisplayName")]
            [Validation(Required=false)]
            public string ProcessDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("processVersion")]
            [Validation(Required=false)]
            public int? ProcessVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>D0001833abb0fb61524487eb01848207bc89b47</para>
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-19 19:36:54</para>
            /// </summary>
            [NameInMap("startTimeGMT")]
            [Validation(Required=false)]
            public string StartTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
