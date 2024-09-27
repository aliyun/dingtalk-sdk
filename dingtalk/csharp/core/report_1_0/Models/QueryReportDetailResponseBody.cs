// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class QueryReportDetailResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryReportDetailResponseBodyContent> Content { get; set; }
        public class QueryReportDetailResponseBodyContent : TeaModel {
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>今日工作</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("sort")]
            [Validation(Required=false)]
            public string Sort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>开发工作</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1507564800000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>部门1</para>
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1507564800000</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18XXXX</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>日报</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
