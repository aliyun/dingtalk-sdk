// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateSceneGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>http://***.png</p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("management_options")
    public UpdateSceneGroupRequestManagementOptions managementOptions;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxxx==</p>
     */
    @NameInMap("open_conversation_id")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>unionid****</p>
     */
    @NameInMap("owner_union_id")
    public String ownerUnionId;

    /**
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("owner_user_id")
    public String ownerUserId;

    /**
     * <strong>example:</strong>
     * <p>客户群</p>
     */
    @NameInMap("title")
    public String title;

    public static UpdateSceneGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSceneGroupRequest self = new UpdateSceneGroupRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSceneGroupRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateSceneGroupRequest setManagementOptions(UpdateSceneGroupRequestManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public UpdateSceneGroupRequestManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public UpdateSceneGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateSceneGroupRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

    public UpdateSceneGroupRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public UpdateSceneGroupRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class UpdateSceneGroupRequestManagementOptions extends TeaModel {
        @NameInMap("add_friend_forbidden")
        public Integer addFriendForbidden;

        @NameInMap("all_members_can_create_calendar")
        public Integer allMembersCanCreateCalendar;

        @NameInMap("all_members_can_create_mcs_conf")
        public Integer allMembersCanCreateMcsConf;

        @NameInMap("chat_banned_type")
        public Integer chatBannedType;

        @NameInMap("group_email_disabled")
        public Integer groupEmailDisabled;

        @NameInMap("group_live_switch")
        public Integer groupLiveSwitch;

        @NameInMap("management_type")
        public Integer managementType;

        @NameInMap("members_to_admin_chat")
        public Integer membersToAdminChat;

        @NameInMap("mention_all_authority")
        public Integer mentionAllAuthority;

        @NameInMap("not_quit_when_emp_leave")
        public Integer notQuitWhenEmpLeave;

        @NameInMap("only_admin_can_add_mem")
        public Integer onlyAdminCanAddMem;

        @NameInMap("only_admin_can_ding")
        public Integer onlyAdminCanDing;

        @NameInMap("only_admin_can_set_msg_top")
        public Integer onlyAdminCanSetMsgTop;

        @NameInMap("plugin_customize_verify")
        public Integer pluginCustomizeVerify;

        @NameInMap("searchable")
        public Integer searchable;

        @NameInMap("show_history_type")
        public Integer showHistoryType;

        @NameInMap("validation_type")
        public Integer validationType;

        public static UpdateSceneGroupRequestManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateSceneGroupRequestManagementOptions self = new UpdateSceneGroupRequestManagementOptions();
            return TeaModel.build(map, self);
        }

        public UpdateSceneGroupRequestManagementOptions setAddFriendForbidden(Integer addFriendForbidden) {
            this.addFriendForbidden = addFriendForbidden;
            return this;
        }
        public Integer getAddFriendForbidden() {
            return this.addFriendForbidden;
        }

        public UpdateSceneGroupRequestManagementOptions setAllMembersCanCreateCalendar(Integer allMembersCanCreateCalendar) {
            this.allMembersCanCreateCalendar = allMembersCanCreateCalendar;
            return this;
        }
        public Integer getAllMembersCanCreateCalendar() {
            return this.allMembersCanCreateCalendar;
        }

        public UpdateSceneGroupRequestManagementOptions setAllMembersCanCreateMcsConf(Integer allMembersCanCreateMcsConf) {
            this.allMembersCanCreateMcsConf = allMembersCanCreateMcsConf;
            return this;
        }
        public Integer getAllMembersCanCreateMcsConf() {
            return this.allMembersCanCreateMcsConf;
        }

        public UpdateSceneGroupRequestManagementOptions setChatBannedType(Integer chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public Integer getChatBannedType() {
            return this.chatBannedType;
        }

        public UpdateSceneGroupRequestManagementOptions setGroupEmailDisabled(Integer groupEmailDisabled) {
            this.groupEmailDisabled = groupEmailDisabled;
            return this;
        }
        public Integer getGroupEmailDisabled() {
            return this.groupEmailDisabled;
        }

        public UpdateSceneGroupRequestManagementOptions setGroupLiveSwitch(Integer groupLiveSwitch) {
            this.groupLiveSwitch = groupLiveSwitch;
            return this;
        }
        public Integer getGroupLiveSwitch() {
            return this.groupLiveSwitch;
        }

        public UpdateSceneGroupRequestManagementOptions setManagementType(Integer managementType) {
            this.managementType = managementType;
            return this;
        }
        public Integer getManagementType() {
            return this.managementType;
        }

        public UpdateSceneGroupRequestManagementOptions setMembersToAdminChat(Integer membersToAdminChat) {
            this.membersToAdminChat = membersToAdminChat;
            return this;
        }
        public Integer getMembersToAdminChat() {
            return this.membersToAdminChat;
        }

        public UpdateSceneGroupRequestManagementOptions setMentionAllAuthority(Integer mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public Integer getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public UpdateSceneGroupRequestManagementOptions setNotQuitWhenEmpLeave(Integer notQuitWhenEmpLeave) {
            this.notQuitWhenEmpLeave = notQuitWhenEmpLeave;
            return this;
        }
        public Integer getNotQuitWhenEmpLeave() {
            return this.notQuitWhenEmpLeave;
        }

        public UpdateSceneGroupRequestManagementOptions setOnlyAdminCanAddMem(Integer onlyAdminCanAddMem) {
            this.onlyAdminCanAddMem = onlyAdminCanAddMem;
            return this;
        }
        public Integer getOnlyAdminCanAddMem() {
            return this.onlyAdminCanAddMem;
        }

        public UpdateSceneGroupRequestManagementOptions setOnlyAdminCanDing(Integer onlyAdminCanDing) {
            this.onlyAdminCanDing = onlyAdminCanDing;
            return this;
        }
        public Integer getOnlyAdminCanDing() {
            return this.onlyAdminCanDing;
        }

        public UpdateSceneGroupRequestManagementOptions setOnlyAdminCanSetMsgTop(Integer onlyAdminCanSetMsgTop) {
            this.onlyAdminCanSetMsgTop = onlyAdminCanSetMsgTop;
            return this;
        }
        public Integer getOnlyAdminCanSetMsgTop() {
            return this.onlyAdminCanSetMsgTop;
        }

        public UpdateSceneGroupRequestManagementOptions setPluginCustomizeVerify(Integer pluginCustomizeVerify) {
            this.pluginCustomizeVerify = pluginCustomizeVerify;
            return this;
        }
        public Integer getPluginCustomizeVerify() {
            return this.pluginCustomizeVerify;
        }

        public UpdateSceneGroupRequestManagementOptions setSearchable(Integer searchable) {
            this.searchable = searchable;
            return this;
        }
        public Integer getSearchable() {
            return this.searchable;
        }

        public UpdateSceneGroupRequestManagementOptions setShowHistoryType(Integer showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public Integer getShowHistoryType() {
            return this.showHistoryType;
        }

        public UpdateSceneGroupRequestManagementOptions setValidationType(Integer validationType) {
            this.validationType = validationType;
            return this;
        }
        public Integer getValidationType() {
            return this.validationType;
        }

    }

}
