// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupDetailInfoResponseBody extends TeaModel {
    @NameInMap("group_url")
    public String groupUrl;

    @NameInMap("icon")
    public String icon;

    @NameInMap("management_options")
    public GetSceneGroupDetailInfoResponseBodyManagementOptions managementOptions;

    @NameInMap("member_amount")
    public Integer memberAmount;

    /**
     * <strong>example:</strong>
     * <p>cidXXXXXXXXX==</p>
     */
    @NameInMap("open_conversation_id")
    public String openConversationId;

    @NameInMap("owner_union_id")
    public String ownerUnionId;

    @NameInMap("owner_user_id")
    public String ownerUserId;

    @NameInMap("scene_data")
    public String sceneData;

    @NameInMap("status")
    public Integer status;

    @NameInMap("sub_admin_staff_ids")
    public java.util.List<String> subAdminStaffIds;

    @NameInMap("sub_admin_union_ids")
    public java.util.List<String> subAdminUnionIds;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("template_id")
    public String templateId;

    @NameInMap("title")
    public String title;

    public static GetSceneGroupDetailInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupDetailInfoResponseBody self = new GetSceneGroupDetailInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupDetailInfoResponseBody setGroupUrl(String groupUrl) {
        this.groupUrl = groupUrl;
        return this;
    }
    public String getGroupUrl() {
        return this.groupUrl;
    }

    public GetSceneGroupDetailInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSceneGroupDetailInfoResponseBody setManagementOptions(GetSceneGroupDetailInfoResponseBodyManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public GetSceneGroupDetailInfoResponseBodyManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public GetSceneGroupDetailInfoResponseBody setMemberAmount(Integer memberAmount) {
        this.memberAmount = memberAmount;
        return this;
    }
    public Integer getMemberAmount() {
        return this.memberAmount;
    }

    public GetSceneGroupDetailInfoResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetSceneGroupDetailInfoResponseBody setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

    public GetSceneGroupDetailInfoResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetSceneGroupDetailInfoResponseBody setSceneData(String sceneData) {
        this.sceneData = sceneData;
        return this;
    }
    public String getSceneData() {
        return this.sceneData;
    }

    public GetSceneGroupDetailInfoResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetSceneGroupDetailInfoResponseBody setSubAdminStaffIds(java.util.List<String> subAdminStaffIds) {
        this.subAdminStaffIds = subAdminStaffIds;
        return this;
    }
    public java.util.List<String> getSubAdminStaffIds() {
        return this.subAdminStaffIds;
    }

    public GetSceneGroupDetailInfoResponseBody setSubAdminUnionIds(java.util.List<String> subAdminUnionIds) {
        this.subAdminUnionIds = subAdminUnionIds;
        return this;
    }
    public java.util.List<String> getSubAdminUnionIds() {
        return this.subAdminUnionIds;
    }

    public GetSceneGroupDetailInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public GetSceneGroupDetailInfoResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetSceneGroupDetailInfoResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class GetSceneGroupDetailInfoResponseBodyManagementOptions extends TeaModel {
        @NameInMap("chat_banned_type")
        public String chatBannedType;

        @NameInMap("management_type")
        public String managementType;

        @NameInMap("mention_all_authority")
        public String mentionAllAuthority;

        @NameInMap("not_quit_when_emp_leave")
        public String notQuitWhenEmpLeave;

        @NameInMap("only_admin_can_add_mem")
        public String onlyAdminCanAddMem;

        @NameInMap("searchable")
        public String searchable;

        @NameInMap("show_history_type")
        public String showHistoryType;

        @NameInMap("validation_type")
        public String validationType;

        public static GetSceneGroupDetailInfoResponseBodyManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            GetSceneGroupDetailInfoResponseBodyManagementOptions self = new GetSceneGroupDetailInfoResponseBodyManagementOptions();
            return TeaModel.build(map, self);
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setChatBannedType(String chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public String getChatBannedType() {
            return this.chatBannedType;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setManagementType(String managementType) {
            this.managementType = managementType;
            return this;
        }
        public String getManagementType() {
            return this.managementType;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setMentionAllAuthority(String mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public String getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setNotQuitWhenEmpLeave(String notQuitWhenEmpLeave) {
            this.notQuitWhenEmpLeave = notQuitWhenEmpLeave;
            return this;
        }
        public String getNotQuitWhenEmpLeave() {
            return this.notQuitWhenEmpLeave;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setOnlyAdminCanAddMem(String onlyAdminCanAddMem) {
            this.onlyAdminCanAddMem = onlyAdminCanAddMem;
            return this;
        }
        public String getOnlyAdminCanAddMem() {
            return this.onlyAdminCanAddMem;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setSearchable(String searchable) {
            this.searchable = searchable;
            return this;
        }
        public String getSearchable() {
            return this.searchable;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setShowHistoryType(String showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public String getShowHistoryType() {
            return this.showHistoryType;
        }

        public GetSceneGroupDetailInfoResponseBodyManagementOptions setValidationType(String validationType) {
            this.validationType = validationType;
            return this;
        }
        public String getValidationType() {
            return this.validationType;
        }

    }

}
