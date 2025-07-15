// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CourseFinishCourseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_code_cert_id_001</para>
        /// </summary>
        [NameInMap("certId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>data:image/(?:png|jpeg|gif|bmp|webp);base64</para>
        /// </summary>
        [NameInMap("certMediaBase64")]
        [Validation(Required=false)]
        public string CertMediaBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>isv_code_course_01</para>
        /// </summary>
        [NameInMap("courseId")]
        [Validation(Required=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
