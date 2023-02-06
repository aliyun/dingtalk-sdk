// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetEmpAttributeHideBySceneSettingResponseBody extends TeaModel {
    /**
     * <p>单聊副标题场景配置，开启时单聊中相关的员工字段不显示</p>
     */
    @NameInMap("chatSubtitleConfig")
    public GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig chatSubtitleConfig;

    /**
     * <p>设置描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>允许查看的部门列表</p>
     */
    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    /**
     * <p>允许查看的角色列表</p>
     */
    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    /**
     * <p>允许查看的员工列表</p>
     */
    @NameInMap("excludeUserIds")
    public java.util.List<String> excludeUserIds;

    /**
     * <p>隐藏字段id列表</p>
     * <p>枚举列表：</p>
     * <p>        department：部门</p>
     * <p>        email：邮箱</p>
     * <p>        manager：直属主管</p>
     * <p>        title：职位</p>
     * <p>        mobile：手机号</p>
     * <p>        ext_number：分机号</p>
     * <p>        work_station：办公地点</p>
     * <p>        remark：备注</p>
     * <p>        hire_date：入职时间</p>
     * <p>        job_number：工号</p>
     */
    @NameInMap("hideFields")
    public java.util.List<String> hideFields;

    /**
     * <p>设置id</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>设置名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>被隐藏的部门列表</p>
     */
    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    /**
     * <p>被隐藏的角色列表</p>
     */
    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    /**
     * <p>被隐藏的员工UserId列表</p>
     */
    @NameInMap("objectUserIds")
    public java.util.List<String> objectUserIds;

    /**
     * <p>用户资料页场景配置，开启时相关的员工字段不在资料页中显示</p>
     */
    @NameInMap("profileSceneConfig")
    public GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig profileSceneConfig;

    /**
     * <p>搜索场景配置，开启时隐藏的字段不在搜索结果中展示，并且不允许根据这些字段搜索到。</p>
     */
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
        /**
         * <p>是否生效</p>
         */
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
        /**
         * <p>是否生效</p>
         */
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
        /**
         * <p>是否生效</p>
         */
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
