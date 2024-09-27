// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class StartCoursePrepareRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-11-16</para>
        /// </summary>
        [NameInMap("courseDate")]
        [Validation(Required=false)]
        public string CourseDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>course1</para>
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>device1</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>extNumber</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DDISV</para>
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("liveCoverImage")]
        [Validation(Required=false)]
        public string LiveCoverImage { get; set; }

        [NameInMap("sectionIndex")]
        [Validation(Required=false)]
        public List<int?> SectionIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manger1234</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
