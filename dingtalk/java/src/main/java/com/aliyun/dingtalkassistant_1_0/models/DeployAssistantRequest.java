// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeployAssistantRequest extends TeaModel {
    @NameInMap("action")
    public DeployAssistantRequestAction action;

    @NameInMap("aiAssistantId")
    public String aiAssistantId;

    @NameInMap("appScopes")
    public DeployAssistantRequestAppScopes appScopes;

    @NameInMap("description")
    public String description;

    @NameInMap("fallback")
    public DeployAssistantRequestFallback fallback;

    @NameInMap("icon")
    public String icon;

    @NameInMap("instructions")
    public String instructions;

    @NameInMap("isPublic")
    public Integer isPublic;

    @NameInMap("name")
    public String name;

    @NameInMap("operateUserId")
    public String operateUserId;

    @NameInMap("recommendPrompts")
    public java.util.List<String> recommendPrompts;

    @NameInMap("shareRecipient")
    public String shareRecipient;

    @NameInMap("toneStyle")
    public String toneStyle;

    @NameInMap("uuid")
    public String uuid;

    @NameInMap("welcomeContent")
    public String welcomeContent;

    @NameInMap("welcomeTitle")
    public String welcomeTitle;

    public static DeployAssistantRequest build(java.util.Map<String, ?> map) throws Exception {
        DeployAssistantRequest self = new DeployAssistantRequest();
        return TeaModel.build(map, self);
    }

    public DeployAssistantRequest setAction(DeployAssistantRequestAction action) {
        this.action = action;
        return this;
    }
    public DeployAssistantRequestAction getAction() {
        return this.action;
    }

    public DeployAssistantRequest setAiAssistantId(String aiAssistantId) {
        this.aiAssistantId = aiAssistantId;
        return this;
    }
    public String getAiAssistantId() {
        return this.aiAssistantId;
    }

    public DeployAssistantRequest setAppScopes(DeployAssistantRequestAppScopes appScopes) {
        this.appScopes = appScopes;
        return this;
    }
    public DeployAssistantRequestAppScopes getAppScopes() {
        return this.appScopes;
    }

    public DeployAssistantRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public DeployAssistantRequest setFallback(DeployAssistantRequestFallback fallback) {
        this.fallback = fallback;
        return this;
    }
    public DeployAssistantRequestFallback getFallback() {
        return this.fallback;
    }

    public DeployAssistantRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public DeployAssistantRequest setInstructions(String instructions) {
        this.instructions = instructions;
        return this;
    }
    public String getInstructions() {
        return this.instructions;
    }

    public DeployAssistantRequest setIsPublic(Integer isPublic) {
        this.isPublic = isPublic;
        return this;
    }
    public Integer getIsPublic() {
        return this.isPublic;
    }

    public DeployAssistantRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DeployAssistantRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public DeployAssistantRequest setRecommendPrompts(java.util.List<String> recommendPrompts) {
        this.recommendPrompts = recommendPrompts;
        return this;
    }
    public java.util.List<String> getRecommendPrompts() {
        return this.recommendPrompts;
    }

    public DeployAssistantRequest setShareRecipient(String shareRecipient) {
        this.shareRecipient = shareRecipient;
        return this;
    }
    public String getShareRecipient() {
        return this.shareRecipient;
    }

    public DeployAssistantRequest setToneStyle(String toneStyle) {
        this.toneStyle = toneStyle;
        return this;
    }
    public String getToneStyle() {
        return this.toneStyle;
    }

    public DeployAssistantRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public DeployAssistantRequest setWelcomeContent(String welcomeContent) {
        this.welcomeContent = welcomeContent;
        return this;
    }
    public String getWelcomeContent() {
        return this.welcomeContent;
    }

    public DeployAssistantRequest setWelcomeTitle(String welcomeTitle) {
        this.welcomeTitle = welcomeTitle;
        return this;
    }
    public String getWelcomeTitle() {
        return this.welcomeTitle;
    }

    public static class DeployAssistantRequestActionActionAuthInfo extends TeaModel {
        @NameInMap("authConfig")
        public String authConfig;

        @NameInMap("authenticationType")
        public String authenticationType;

        public static DeployAssistantRequestActionActionAuthInfo build(java.util.Map<String, ?> map) throws Exception {
            DeployAssistantRequestActionActionAuthInfo self = new DeployAssistantRequestActionActionAuthInfo();
            return TeaModel.build(map, self);
        }

        public DeployAssistantRequestActionActionAuthInfo setAuthConfig(String authConfig) {
            this.authConfig = authConfig;
            return this;
        }
        public String getAuthConfig() {
            return this.authConfig;
        }

        public DeployAssistantRequestActionActionAuthInfo setAuthenticationType(String authenticationType) {
            this.authenticationType = authenticationType;
            return this;
        }
        public String getAuthenticationType() {
            return this.authenticationType;
        }

    }

    public static class DeployAssistantRequestAction extends TeaModel {
        @NameInMap("actionAuthInfo")
        public DeployAssistantRequestActionActionAuthInfo actionAuthInfo;

        @NameInMap("actionName")
        public String actionName;

        @NameInMap("description")
        public String description;

        @NameInMap("schema")
        public String schema;

        public static DeployAssistantRequestAction build(java.util.Map<String, ?> map) throws Exception {
            DeployAssistantRequestAction self = new DeployAssistantRequestAction();
            return TeaModel.build(map, self);
        }

        public DeployAssistantRequestAction setActionAuthInfo(DeployAssistantRequestActionActionAuthInfo actionAuthInfo) {
            this.actionAuthInfo = actionAuthInfo;
            return this;
        }
        public DeployAssistantRequestActionActionAuthInfo getActionAuthInfo() {
            return this.actionAuthInfo;
        }

        public DeployAssistantRequestAction setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public DeployAssistantRequestAction setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public DeployAssistantRequestAction setSchema(String schema) {
            this.schema = schema;
            return this;
        }
        public String getSchema() {
            return this.schema;
        }

    }

    public static class DeployAssistantRequestAppScopes extends TeaModel {
        @NameInMap("deptVisibleScopes")
        public String deptVisibleScopes;

        @NameInMap("dynamicGroupScopes")
        public String dynamicGroupScopes;

        @NameInMap("isHidden")
        public Boolean isHidden;

        @NameInMap("roleVisibleScopes")
        public String roleVisibleScopes;

        @NameInMap("userVisibleScopes")
        public String userVisibleScopes;

        public static DeployAssistantRequestAppScopes build(java.util.Map<String, ?> map) throws Exception {
            DeployAssistantRequestAppScopes self = new DeployAssistantRequestAppScopes();
            return TeaModel.build(map, self);
        }

        public DeployAssistantRequestAppScopes setDeptVisibleScopes(String deptVisibleScopes) {
            this.deptVisibleScopes = deptVisibleScopes;
            return this;
        }
        public String getDeptVisibleScopes() {
            return this.deptVisibleScopes;
        }

        public DeployAssistantRequestAppScopes setDynamicGroupScopes(String dynamicGroupScopes) {
            this.dynamicGroupScopes = dynamicGroupScopes;
            return this;
        }
        public String getDynamicGroupScopes() {
            return this.dynamicGroupScopes;
        }

        public DeployAssistantRequestAppScopes setIsHidden(Boolean isHidden) {
            this.isHidden = isHidden;
            return this;
        }
        public Boolean getIsHidden() {
            return this.isHidden;
        }

        public DeployAssistantRequestAppScopes setRoleVisibleScopes(String roleVisibleScopes) {
            this.roleVisibleScopes = roleVisibleScopes;
            return this;
        }
        public String getRoleVisibleScopes() {
            return this.roleVisibleScopes;
        }

        public DeployAssistantRequestAppScopes setUserVisibleScopes(String userVisibleScopes) {
            this.userVisibleScopes = userVisibleScopes;
            return this;
        }
        public String getUserVisibleScopes() {
            return this.userVisibleScopes;
        }

    }

    public static class DeployAssistantRequestFallback extends TeaModel {
        @NameInMap("actionType")
        public String actionType;

        @NameInMap("defaultMsg")
        public String defaultMsg;

        public static DeployAssistantRequestFallback build(java.util.Map<String, ?> map) throws Exception {
            DeployAssistantRequestFallback self = new DeployAssistantRequestFallback();
            return TeaModel.build(map, self);
        }

        public DeployAssistantRequestFallback setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public DeployAssistantRequestFallback setDefaultMsg(String defaultMsg) {
            this.defaultMsg = defaultMsg;
            return this;
        }
        public String getDefaultMsg() {
            return this.defaultMsg;
        }

    }

}
