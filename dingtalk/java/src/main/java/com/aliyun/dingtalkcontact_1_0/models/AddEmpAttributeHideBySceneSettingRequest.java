// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddEmpAttributeHideBySceneSettingRequest extends TeaModel {
    @NameInMap("chatSubtitleConfig")
    public AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig chatSubtitleConfig;

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
    public AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

    @NameInMap("searchSceneConfig")
    public AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig searchSceneConfig;

    public static AddEmpAttributeHideBySceneSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        AddEmpAttributeHideBySceneSettingRequest self = new AddEmpAttributeHideBySceneSettingRequest();
        return TeaModel.build(map, self);
    }

    public AddEmpAttributeHideBySceneSettingRequest setChatSubtitleConfig(AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig chatSubtitleConfig) {
        this.chatSubtitleConfig = chatSubtitleConfig;
        return this;
    }
    public AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig getChatSubtitleConfig() {
        return this.chatSubtitleConfig;
    }

    public AddEmpAttributeHideBySceneSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddEmpAttributeHideBySceneSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setHideFields(java.util.List<String> hideFields) {
        this.hideFields = hideFields;
        return this;
    }
    public java.util.List<String> getHideFields() {
        return this.hideFields;
    }

    public AddEmpAttributeHideBySceneSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddEmpAttributeHideBySceneSettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public AddEmpAttributeHideBySceneSettingRequest setProfileSceneConfig(AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public AddEmpAttributeHideBySceneSettingRequest setSearchSceneConfig(AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig build(java.util.Map<String, ?> map) throws Exception {
            AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig self = new AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig();
            return TeaModel.build(map, self);
        }

        public AddEmpAttributeHideBySceneSettingRequestChatSubtitleConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig self = new AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public AddEmpAttributeHideBySceneSettingRequestProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig self = new AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public AddEmpAttributeHideBySceneSettingRequestSearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

}
