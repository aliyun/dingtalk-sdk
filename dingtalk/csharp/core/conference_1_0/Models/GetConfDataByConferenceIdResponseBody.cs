// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class GetConfDataByConferenceIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6449d8a6414xxxxxxxx01464af9f0</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>njMTqKo9xxxxEiE</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("creatorNick")]
        [Validation(Required=false)]
        public string CreatorNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1682561790000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("freeType")]
        [Validation(Required=false)]
        public string FreeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding_talk</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1682561190000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600000</para>
        /// </summary>
        [NameInMap("timeLength")]
        [Validation(Required=false)]
        public long? TimeLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx测试会议</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("userCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

    }

}
