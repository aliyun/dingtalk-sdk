// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetEmpAttributeHideBySceneSettingResponseBody extends TeaModel {
    @NameInMap("chatSubtitleConfig")
    public GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig chatSubtitleConfig;

    /**
     * <strong>example:</strong>
     * <p>描述信息</p>
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
     * <p>123456</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <strong>example:</strong>
     * <p>设置1</p>
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
    public GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig profileSceneConfig;

    @NameInMap("searchSceneConfig")
    public GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig searchSceneConfig;

    public static GetEmpAttributeHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEmpAttributeHideBySceneSettingResponseBody self = new GetEmpAttributeHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setChatSubtitleConfig(GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig chatSubtitleConfig) {
        this.chatSubtitleConfig = chatSubtitleConfig;
        return this;
    }
    public GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig getChatSubtitleConfig() {
        return this.chatSubtitleConfig;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setHideFields(java.util.List<String> hideFields) {
        this.hideFields = hideFields;
        return this;
    }
    public java.util.List<String> getHideFields() {
        return this.hideFields;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setProfileSceneConfig(GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public GetEmpAttributeHideBySceneSettingResponseBody setSearchSceneConfig(GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig build(java.util.Map<String, ?> map) throws Exception {
            GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig self = new GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig();
            return TeaModel.build(map, self);
        }

        public GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig self = new GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig extends TeaModel {
        @NameInMap("active")
        public Boolean active;

        public static GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig self = new GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

}
