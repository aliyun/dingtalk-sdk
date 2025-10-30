// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models
{
    public class GetBlackboardResponseBody : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<GetBlackboardResponseBodyAttachments> Attachments { get; set; }
        public class GetBlackboardResponseBodyAttachments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>附件.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example_category_id</para>
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分类示例</para>
        /// </summary>
        [NameInMap("categoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>公告内容示例</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://down.dingtalk.com/ddmedia/xxxx.png?ddFrom=blackboard.pic">https://down.dingtalk.com/ddmedia/xxxx.png?ddFrom=blackboard.pic</a></para>
        /// </summary>
        [NameInMap("coverPicUrl")]
        [Validation(Required=false)]
        public string CoverPicUrl { get; set; }

        [NameInMap("depNameList")]
        [Validation(Required=false)]
        public List<string> DepNameList { get; set; }

        [NameInMap("deptList")]
        [Validation(Required=false)]
        public List<GetBlackboardResponseBodyDeptList> DeptList { get; set; }
        public class GetBlackboardResponseBodyDeptList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example_dept_id</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx部门</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fbeaxxxxxxxxxxxxxxxxxxxxxxxxe292</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isPushTop")]
        [Validation(Required=false)]
        public long? IsPushTop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("privateLevel")]
        [Validation(Required=false)]
        public long? PrivateLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("readCount")]
        [Validation(Required=false)]
        public long? ReadCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager01</para>
        /// </summary>
        [NameInMap("senderStaffId")]
        [Validation(Required=false)]
        public string SenderStaffId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>公告标题实例</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("unReadCount")]
        [Validation(Required=false)]
        public long? UnReadCount { get; set; }

        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<GetBlackboardResponseBodyUserList> UserList { get; set; }
        public class GetBlackboardResponseBodyUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingxxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例员工名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager01</para>
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

        }

        [NameInMap("userNameList")]
        [Validation(Required=false)]
        public List<string> UserNameList { get; set; }

    }

}
