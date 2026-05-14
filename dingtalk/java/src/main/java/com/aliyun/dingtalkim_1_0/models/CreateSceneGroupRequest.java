// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>http://***.png</p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("management_options")
    public CreateSceneGroupRequestManagementOptions managementOptions;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1107****2120</p>
     */
    @NameInMap("owner_user_id")
    public String ownerUserId;

    @NameInMap("subadmin_ids")
    public java.util.List<String> subadminIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8d42****nkld</p>
     */
    @NameInMap("template_id")
    public String templateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>客户群</p>
     */
    @NameInMap("title")
    public String title;

    @NameInMap("user_ids")
    public java.util.List<String> userIds;

    /**
     * <strong>example:</strong>
     * <p>asdazxc</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static CreateSceneGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupRequest self = new CreateSceneGroupRequest();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateSceneGroupRequest setManagementOptions(CreateSceneGroupRequestManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public CreateSceneGroupRequestManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public CreateSceneGroupRequest setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public CreateSceneGroupRequest setSubadminIds(java.util.List<String> subadminIds) {
        this.subadminIds = subadminIds;
        return this;
    }
    public java.util.List<String> getSubadminIds() {
        return this.subadminIds;
    }

    public CreateSceneGroupRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateSceneGroupRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateSceneGroupRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public CreateSceneGroupRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class CreateSceneGroupRequestManagementOptions extends TeaModel {
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

        @NameInMap("searchable")
        public Integer searchable;

        @NameInMap("show_history_type")
        public Integer showHistoryType;

        @NameInMap("validation_type")
        public Integer validationType;

        public static CreateSceneGroupRequestManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            CreateSceneGroupRequestManagementOptions self = new CreateSceneGroupRequestManagementOptions();
            return TeaModel.build(map, self);
        }

        public CreateSceneGroupRequestManagementOptions setAddFriendForbidden(Integer addFriendForbidden) {
            this.addFriendForbidden = addFriendForbidden;
            return this;
        }
        public Integer getAddFriendForbidden() {
            return this.addFriendForbidden;
        }

        public CreateSceneGroupRequestManagementOptions setAllMembersCanCreateCalendar(Integer allMembersCanCreateCalendar) {
            this.allMembersCanCreateCalendar = allMembersCanCreateCalendar;
            return this;
        }
        public Integer getAllMembersCanCreateCalendar() {
            return this.allMembersCanCreateCalendar;
        }

        public CreateSceneGroupRequestManagementOptions setAllMembersCanCreateMcsConf(Integer allMembersCanCreateMcsConf) {
            this.allMembersCanCreateMcsConf = allMembersCanCreateMcsConf;
            return this;
        }
        public Integer getAllMembersCanCreateMcsConf() {
            return this.allMembersCanCreateMcsConf;
        }

        public CreateSceneGroupRequestManagementOptions setChatBannedType(Integer chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public Integer getChatBannedType() {
            return this.chatBannedType;
        }

        public CreateSceneGroupRequestManagementOptions setGroupEmailDisabled(Integer groupEmailDisabled) {
            this.groupEmailDisabled = groupEmailDisabled;
            return this;
        }
        public Integer getGroupEmailDisabled() {
            return this.groupEmailDisabled;
        }

        public CreateSceneGroupRequestManagementOptions setGroupLiveSwitch(Integer groupLiveSwitch) {
            this.groupLiveSwitch = groupLiveSwitch;
            return this;
        }
        public Integer getGroupLiveSwitch() {
            return this.groupLiveSwitch;
        }

        public CreateSceneGroupRequestManagementOptions setManagementType(Integer managementType) {
            this.managementType = managementType;
            return this;
        }
        public Integer getManagementType() {
            return this.managementType;
        }

        public CreateSceneGroupRequestManagementOptions setMembersToAdminChat(Integer membersToAdminChat) {
            this.membersToAdminChat = membersToAdminChat;
            return this;
        }
        public Integer getMembersToAdminChat() {
            return this.membersToAdminChat;
        }

        public CreateSceneGroupRequestManagementOptions setMentionAllAuthority(Integer mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public Integer getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public CreateSceneGroupRequestManagementOptions setNotQuitWhenEmpLeave(Integer notQuitWhenEmpLeave) {
            this.notQuitWhenEmpLeave = notQuitWhenEmpLeave;
            return this;
        }
        public Integer getNotQuitWhenEmpLeave() {
            return this.notQuitWhenEmpLeave;
        }

        public CreateSceneGroupRequestManagementOptions setOnlyAdminCanAddMem(Integer onlyAdminCanAddMem) {
            this.onlyAdminCanAddMem = onlyAdminCanAddMem;
            return this;
        }
        public Integer getOnlyAdminCanAddMem() {
            return this.onlyAdminCanAddMem;
        }

        public CreateSceneGroupRequestManagementOptions setOnlyAdminCanDing(Integer onlyAdminCanDing) {
            this.onlyAdminCanDing = onlyAdminCanDing;
            return this;
        }
        public Integer getOnlyAdminCanDing() {
            return this.onlyAdminCanDing;
        }

        public CreateSceneGroupRequestManagementOptions setOnlyAdminCanSetMsgTop(Integer onlyAdminCanSetMsgTop) {
            this.onlyAdminCanSetMsgTop = onlyAdminCanSetMsgTop;
            return this;
        }
        public Integer getOnlyAdminCanSetMsgTop() {
            return this.onlyAdminCanSetMsgTop;
        }

        public CreateSceneGroupRequestManagementOptions setSearchable(Integer searchable) {
            this.searchable = searchable;
            return this;
        }
        public Integer getSearchable() {
            return this.searchable;
        }

        public CreateSceneGroupRequestManagementOptions setShowHistoryType(Integer showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public Integer getShowHistoryType() {
            return this.showHistoryType;
        }

        public CreateSceneGroupRequestManagementOptions setValidationType(Integer validationType) {
            this.validationType = validationType;
            return this;
        }
        public Integer getValidationType() {
            return this.validationType;
        }

    }

}
