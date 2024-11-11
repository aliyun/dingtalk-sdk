// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchCreateStudentClassRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>classxxx</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("classType")]
        [Validation(Required=false)]
        public int? ClassType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
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

        [NameInMap("studentList")]
        [Validation(Required=false)]
        public List<BatchCreateStudentClassRequestStudentList> StudentList { get; set; }
        public class BatchCreateStudentClassRequestStudentList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>studentxxx</para>
            /// </summary>
            [NameInMap("studentUserId")]
            [Validation(Required=false)]
            public string StudentUserId { get; set; }

        }

    }

}
