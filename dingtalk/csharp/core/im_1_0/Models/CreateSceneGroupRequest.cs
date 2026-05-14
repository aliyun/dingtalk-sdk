// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateSceneGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http://***.png</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("management_options")]
        [Validation(Required=false)]
        public CreateSceneGroupRequestManagementOptions ManagementOptions { get; set; }
        public class CreateSceneGroupRequestManagementOptions : TeaModel {
            [NameInMap("add_friend_forbidden")]
            [Validation(Required=false)]
            public int? AddFriendForbidden { get; set; }

            [NameInMap("all_members_can_create_calendar")]
            [Validation(Required=false)]
            public int? AllMembersCanCreateCalendar { get; set; }

            [NameInMap("all_members_can_create_mcs_conf")]
            [Validation(Required=false)]
            public int? AllMembersCanCreateMcsConf { get; set; }

            [NameInMap("chat_banned_type")]
            [Validation(Required=false)]
            public int? ChatBannedType { get; set; }

            [NameInMap("group_email_disabled")]
            [Validation(Required=false)]
            public int? GroupEmailDisabled { get; set; }

            [NameInMap("group_live_switch")]
            [Validation(Required=false)]
            public int? GroupLiveSwitch { get; set; }

            [NameInMap("management_type")]
            [Validation(Required=false)]
            public int? ManagementType { get; set; }

            [NameInMap("members_to_admin_chat")]
            [Validation(Required=false)]
            public int? MembersToAdminChat { get; set; }

            [NameInMap("mention_all_authority")]
            [Validation(Required=false)]
            public int? MentionAllAuthority { get; set; }

            [NameInMap("not_quit_when_emp_leave")]
            [Validation(Required=false)]
            public int? NotQuitWhenEmpLeave { get; set; }

            [NameInMap("only_admin_can_add_mem")]
            [Validation(Required=false)]
            public int? OnlyAdminCanAddMem { get; set; }

            [NameInMap("only_admin_can_ding")]
            [Validation(Required=false)]
            public int? OnlyAdminCanDing { get; set; }

            [NameInMap("only_admin_can_set_msg_top")]
            [Validation(Required=false)]
            public int? OnlyAdminCanSetMsgTop { get; set; }

            [NameInMap("searchable")]
            [Validation(Required=false)]
            public int? Searchable { get; set; }

            [NameInMap("show_history_type")]
            [Validation(Required=false)]
            public int? ShowHistoryType { get; set; }

            [NameInMap("validation_type")]
            [Validation(Required=false)]
            public int? ValidationType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("owner_user_id")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("subadmin_ids")]
        [Validation(Required=false)]
        public List<string> SubadminIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d42****nkld</para>
        /// </summary>
        [NameInMap("template_id")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户群</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("user_ids")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asdazxc</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
