// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryTransferCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryTransferCourseResponseBodyResult Result { get; set; }
        public class QueryTransferCourseResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>classIdx</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>一年级一班</para>
            /// </summary>
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding_xxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ISV_XXX</para>
            /// </summary>
            [NameInMap("isvCode")]
            [Validation(Required=false)]
            public string IsvCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>record_xxx</para>
            /// </summary>
            [NameInMap("isvRecordId")]
            [Validation(Required=false)]
            public string IsvRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>srcCode</para>
            /// </summary>
            [NameInMap("srcCourseCode")]
            [Validation(Required=false)]
            public string SrcCourseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("srcCourseDate")]
            [Validation(Required=false)]
            public long? SrcCourseDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>srcName</para>
            /// </summary>
            [NameInMap("srcCourseName")]
            [Validation(Required=false)]
            public string SrcCourseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>srcId</para>
            /// </summary>
            [NameInMap("srcIsvCourseId")]
            [Validation(Required=false)]
            public string SrcIsvCourseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>第一节</para>
            /// </summary>
            [NameInMap("srcTimeslotName")]
            [Validation(Required=false)]
            public string SrcTimeslotName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("srcTimeslotNum")]
            [Validation(Required=false)]
            public int? SrcTimeslotNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tarCode</para>
            /// </summary>
            [NameInMap("tarCourseCode")]
            [Validation(Required=false)]
            public string TarCourseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("tarCourseDate")]
            [Validation(Required=false)]
            public long? TarCourseDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tarName</para>
            /// </summary>
            [NameInMap("tarCourseName")]
            [Validation(Required=false)]
            public string TarCourseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tarId</para>
            /// </summary>
            [NameInMap("tarIsvCourseId")]
            [Validation(Required=false)]
            public string TarIsvCourseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>第一节</para>
            /// </summary>
            [NameInMap("tarTimeslotName")]
            [Validation(Required=false)]
            public string TarTimeslotName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tarTimeslotNum")]
            [Validation(Required=false)]
            public int? TarTimeslotNum { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
