// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateSceneGroupConversationRequest extends TeaModel {
    /**
     * <p>功能增强</p>
     */
    @NameInMap("features")
    public java.util.Map<String, String> features;

    /**
     * <p>群名称。</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>群主(钉外用户)userId。</p>
     */
    @NameInMap("groupOwnerId")
    public String groupOwnerId;

    /**
     * <p>群头像。</p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("managementOptions")
    public CreateSceneGroupConversationRequestManagementOptions managementOptions;

    /**
     * <p>群模板Id。</p>
     */
    @NameInMap("templateId")
    public String templateId;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    /**
     * <p>建群去重的业务ID。</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static CreateSceneGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSceneGroupConversationRequest self = new CreateSceneGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateSceneGroupConversationRequest setFeatures(java.util.Map<String, String> features) {
        this.features = features;
        return this;
    }
    public java.util.Map<String, String> getFeatures() {
        return this.features;
    }

    public CreateSceneGroupConversationRequest setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public CreateSceneGroupConversationRequest setGroupOwnerId(String groupOwnerId) {
        this.groupOwnerId = groupOwnerId;
        return this;
    }
    public String getGroupOwnerId() {
        return this.groupOwnerId;
    }

    public CreateSceneGroupConversationRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public CreateSceneGroupConversationRequest setManagementOptions(CreateSceneGroupConversationRequestManagementOptions managementOptions) {
        this.managementOptions = managementOptions;
        return this;
    }
    public CreateSceneGroupConversationRequestManagementOptions getManagementOptions() {
        return this.managementOptions;
    }

    public CreateSceneGroupConversationRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateSceneGroupConversationRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

    public CreateSceneGroupConversationRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class CreateSceneGroupConversationRequestManagementOptions extends TeaModel {
        /**
         * <p>群禁言，0-默认，不禁言，1-全员禁言</p>
         */
        @NameInMap("chatBannedType")
        public Integer chatBannedType;

        /**
         * <p>管理类型，0-默认，所有人可管理，1-仅群主可管理</p>
         */
        @NameInMap("managementType")
        public Integer managementType;

        /**
         * <p>@ all 权限，0-默认，所有人，1-仅群主可@all</p>
         */
        @NameInMap("mentionAllAuthority")
        public Integer mentionAllAuthority;

        /**
         * <p>群可搜索，0-默认，不可搜索，1-可搜索</p>
         */
        @NameInMap("searchable")
        public Integer searchable;

        /**
         * <p>新成员是否可查看聊天历史消息，0-默认，否，1-是</p>
         */
        @NameInMap("showHistoryType")
        public Integer showHistoryType;

        /**
         * <p>入群验证，0：不入群验证（默认） 1：入群验证</p>
         */
        @NameInMap("validationType")
        public Integer validationType;

        public static CreateSceneGroupConversationRequestManagementOptions build(java.util.Map<String, ?> map) throws Exception {
            CreateSceneGroupConversationRequestManagementOptions self = new CreateSceneGroupConversationRequestManagementOptions();
            return TeaModel.build(map, self);
        }

        public CreateSceneGroupConversationRequestManagementOptions setChatBannedType(Integer chatBannedType) {
            this.chatBannedType = chatBannedType;
            return this;
        }
        public Integer getChatBannedType() {
            return this.chatBannedType;
        }

        public CreateSceneGroupConversationRequestManagementOptions setManagementType(Integer managementType) {
            this.managementType = managementType;
            return this;
        }
        public Integer getManagementType() {
            return this.managementType;
        }

        public CreateSceneGroupConversationRequestManagementOptions setMentionAllAuthority(Integer mentionAllAuthority) {
            this.mentionAllAuthority = mentionAllAuthority;
            return this;
        }
        public Integer getMentionAllAuthority() {
            return this.mentionAllAuthority;
        }

        public CreateSceneGroupConversationRequestManagementOptions setSearchable(Integer searchable) {
            this.searchable = searchable;
            return this;
        }
        public Integer getSearchable() {
            return this.searchable;
        }

        public CreateSceneGroupConversationRequestManagementOptions setShowHistoryType(Integer showHistoryType) {
            this.showHistoryType = showHistoryType;
            return this;
        }
        public Integer getShowHistoryType() {
            return this.showHistoryType;
        }

        public CreateSceneGroupConversationRequestManagementOptions setValidationType(Integer validationType) {
            this.validationType = validationType;
            return this;
        }
        public Integer getValidationType() {
            return this.validationType;
        }

    }

}
