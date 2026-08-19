// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSceneGroupDetailInfoResponseBody : TeaModel {
        [NameInMap("group_url")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("management_options")]
        [Validation(Required=false)]
        public GetSceneGroupDetailInfoResponseBodyManagementOptions ManagementOptions { get; set; }
        public class GetSceneGroupDetailInfoResponseBodyManagementOptions : TeaModel {
            [NameInMap("chat_banned_type")]
            [Validation(Required=false)]
            public string ChatBannedType { get; set; }

            [NameInMap("management_type")]
            [Validation(Required=false)]
            public string ManagementType { get; set; }

            [NameInMap("mention_all_authority")]
            [Validation(Required=false)]
            public string MentionAllAuthority { get; set; }

            [NameInMap("not_quit_when_emp_leave")]
            [Validation(Required=false)]
            public string NotQuitWhenEmpLeave { get; set; }

            [NameInMap("only_admin_can_add_mem")]
            [Validation(Required=false)]
            public string OnlyAdminCanAddMem { get; set; }

            [NameInMap("searchable")]
            [Validation(Required=false)]
            public string Searchable { get; set; }

            [NameInMap("show_history_type")]
            [Validation(Required=false)]
            public string ShowHistoryType { get; set; }

            [NameInMap("validation_type")]
            [Validation(Required=false)]
            public string ValidationType { get; set; }

        }

        [NameInMap("member_amount")]
        [Validation(Required=false)]
        public int? MemberAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidXXXXXXXXX==</para>
        /// </summary>
        [NameInMap("open_conversation_id")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("owner_union_id")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

        [NameInMap("owner_user_id")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("scene_data")]
        [Validation(Required=false)]
        public string SceneData { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("sub_admin_staff_ids")]
        [Validation(Required=false)]
        public List<string> SubAdminStaffIds { get; set; }

        [NameInMap("sub_admin_union_ids")]
        [Validation(Required=false)]
        public List<string> SubAdminUnionIds { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("template_id")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
