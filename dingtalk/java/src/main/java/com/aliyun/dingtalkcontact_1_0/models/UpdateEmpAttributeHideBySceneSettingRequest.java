// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttributeHideBySceneSettingRequest extends TeaModel {
    @NameInMap("chatSubtitleConfig")
    public UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig chatSubtitleConfig;

    /**
     * <strong>example:</strong>
     * <p>description text</p>
     */
    @NameInMap("description")
    public String description;

    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    @NameInMap("excludeUserIds")
    public java.util.List<String> excludeUserIds;

    @NameInMap("hideFields")
    public java.util.List<String> hideFields;

    /**
     * <strong>example:</strong>
     * <p>test name</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    @NameInMap("objectUserIds")
    public java.util.List<String> objectUserIds;

    @NameInMap("profileSceneConfig")
    public UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

    @NameInMap("searchSceneConfig")
    public UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig searchSceneConfig;

    public static UpdateEmpAttributeHideBySceneSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttributeHideBySceneSettingRequest self = new UpdateEmpAttributeHideBySceneSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setChatSubtitleConfig(UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig chatSubtitleConfig) {
        this.chatSubtitleConfig = chatSubtitleConfig;
        return this;
    }
    public UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig getChatSubtitleConfig() {
        return this.chatSubtitleConfig;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setHideFields(java.util.List<String> hideFields) {
        this.hideFields = hideFields;
        return this;
    }
    public java.util.List<String> getHideFields() {
        return this.hideFields;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setProfileSceneConfig(UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public UpdateEmpAttributeHideBySceneSettingRequest setSearchSceneConfig(UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig self = new UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig();
            return TeaModel.build(map, self);
        }

        public UpdateEmpAttributeHideBySceneSettingRequestChatSubtitleConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig self = new UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateEmpAttributeHideBySceneSettingRequestProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig self = new UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateEmpAttributeHideBySceneSettingRequestSearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

}
