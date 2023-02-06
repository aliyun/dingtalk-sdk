// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetContactHideBySceneSettingResponseBody extends TeaModel {
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
     * <p>浏览组织架构与选人组件场景下的配置</p>
     */
    @NameInMap("nodeListSceneConfig")
    public GetContactHideBySceneSettingResponseBodyNodeListSceneConfig nodeListSceneConfig;

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
     * <p>用户详情场景下的配置</p>
     */
    @NameInMap("profileSceneConfig")
    public GetContactHideBySceneSettingResponseBodyProfileSceneConfig profileSceneConfig;

    /**
     * <p>搜索的场景配置（包括搜索部门、搜索员工）</p>
     */
    @NameInMap("searchSceneConfig")
    public GetContactHideBySceneSettingResponseBodySearchSceneConfig searchSceneConfig;

    public static GetContactHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContactHideBySceneSettingResponseBody self = new GetContactHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContactHideBySceneSettingResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetContactHideBySceneSettingResponseBody setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public GetContactHideBySceneSettingResponseBody setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public GetContactHideBySceneSettingResponseBody setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public GetContactHideBySceneSettingResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public GetContactHideBySceneSettingResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetContactHideBySceneSettingResponseBody setNodeListSceneConfig(GetContactHideBySceneSettingResponseBodyNodeListSceneConfig nodeListSceneConfig) {
        this.nodeListSceneConfig = nodeListSceneConfig;
        return this;
    }
    public GetContactHideBySceneSettingResponseBodyNodeListSceneConfig getNodeListSceneConfig() {
        return this.nodeListSceneConfig;
    }

    public GetContactHideBySceneSettingResponseBody setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public GetContactHideBySceneSettingResponseBody setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public GetContactHideBySceneSettingResponseBody setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public GetContactHideBySceneSettingResponseBody setProfileSceneConfig(GetContactHideBySceneSettingResponseBodyProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public GetContactHideBySceneSettingResponseBodyProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public GetContactHideBySceneSettingResponseBody setSearchSceneConfig(GetContactHideBySceneSettingResponseBodySearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public GetContactHideBySceneSettingResponseBodySearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class GetContactHideBySceneSettingResponseBodyNodeListSceneConfig extends TeaModel {
        /**
         * <p>是否生效</p>
         */
        @NameInMap("active")
        public Boolean active;

        /**
         * <p>是否同时隐藏被隐藏部门下的员工，默认为true。如果为false，仅部门不可见，但是允许跳转到被隐藏部门查看部门下员工。</p>
         */
        @NameInMap("deptObjectIncludeEmp")
        public Boolean deptObjectIncludeEmp;

        public static GetContactHideBySceneSettingResponseBodyNodeListSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetContactHideBySceneSettingResponseBodyNodeListSceneConfig self = new GetContactHideBySceneSettingResponseBodyNodeListSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetContactHideBySceneSettingResponseBodyNodeListSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public GetContactHideBySceneSettingResponseBodyNodeListSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

    public static class GetContactHideBySceneSettingResponseBodyProfileSceneConfig extends TeaModel {
        /**
         * <p>是否生效</p>
         */
        @NameInMap("active")
        public Boolean active;

        public static GetContactHideBySceneSettingResponseBodyProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetContactHideBySceneSettingResponseBodyProfileSceneConfig self = new GetContactHideBySceneSettingResponseBodyProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetContactHideBySceneSettingResponseBodyProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class GetContactHideBySceneSettingResponseBodySearchSceneConfig extends TeaModel {
        /**
         * <p>是否生效</p>
         */
        @NameInMap("active")
        public Boolean active;

        /**
         * <p>是否同时隐藏被隐藏的部门下的员工，默认为true。如果为false，objectDeptIds中的部门无法被搜索，但是员工仍然可以被搜索</p>
         */
        @NameInMap("deptObjectIncludeEmp")
        public Boolean deptObjectIncludeEmp;

        public static GetContactHideBySceneSettingResponseBodySearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            GetContactHideBySceneSettingResponseBodySearchSceneConfig self = new GetContactHideBySceneSettingResponseBodySearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public GetContactHideBySceneSettingResponseBodySearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public GetContactHideBySceneSettingResponseBodySearchSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

}
