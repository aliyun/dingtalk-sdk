// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSuperAdminOpenSceneGroupInfoResponseBody extends TeaModel {
    @NameInMap("groupUrl")
    public String groupUrl;

    @NameInMap("icon")
    public String icon;

    @NameInMap("managementOptions")
    public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions managementOptions;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("subAdminUserIds")
    public java.util.List<String> subAdminUserIds;

    @NameInMap("sucess")
    public Boolean sucess;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("title")
    public String title;

    public static GetSuperAdminOpenSceneGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSuperAdminOpenSceneGroupInfoResponseBody self = new GetSuperAdminOpenSceneGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setGroupUrl(String groupUrl) {
        this.groupUrl = groupUrl;
        return this;
    }
    public String getGroupUrl() {
        return this.groupUrl;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setManagementOptions(GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setSubAdminUserIds(java.util.List<String> subAdminUserIds) {
        this.subAdminUserIds = subAdminUserIds;
        return this;
    }
    public java.util.List<String> getSubAdminUserIds() {
        return this.subAdminUserIds;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setSucess(Boolean sucess) {
        this.sucess = sucess;
        return this;
    }
    public Boolean getSucess() {
        return this.sucess;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetSuperAdminOpenSceneGroupInfoResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions extends TeaModel {
        @NameInMap("chatBannedType")
        public String chatBannedType;

        @NameInMap("managementType")
        public String managementType;

        @NameInMap("mentionAllAuthority")
        public String mentionAllAuthority;

        @NameInMap("searchable")
        public String searchable;

        @NameInMap("showHistoryType")
        public String showHistoryType;

        @NameInMap("validationType")
        public String validationType;

        public static GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions self = new GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions();
            return TeaModel.build(map, self);
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setChatBannedType(String chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public String getChatBannedType() {
            return this.chatBannedType;
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setManagementType(String managementType) {
            this.managementType = managementType;
            return this;
        }
        public String getManagementType() {
            return this.managementType;
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setMentionAllAuthority(String mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public String getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setSearchable(String searchable) {
            this.searchable = searchable;
            return this;
        }
        public String getSearchable() {
            return this.searchable;
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setShowHistoryType(String showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public String getShowHistoryType() {
            return this.showHistoryType;
        }

        public GetSuperAdminOpenSceneGroupInfoResponseBodyManagementOptions setValidationType(String validationType) {
            this.validationType = validationType;
            return this;
        }
        public String getValidationType() {
            return this.validationType;
        }

    }

}
