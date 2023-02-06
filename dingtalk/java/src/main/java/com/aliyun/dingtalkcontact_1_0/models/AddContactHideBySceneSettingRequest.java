// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddContactHideBySceneSettingRequest extends TeaModel {
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
     * <p>设置名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>浏览组织架构与选人组件场景下的配置</p>
     */
    @NameInMap("nodeListSceneConfig")
    public AddContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig;

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
    public AddContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

    /**
     * <p>搜索的场景配置（包括搜索部门、搜索员工）</p>
     */
    @NameInMap("searchSceneConfig")
    public AddContactHideBySceneSettingRequestSearchSceneConfig searchSceneConfig;

    public static AddContactHideBySceneSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        AddContactHideBySceneSettingRequest self = new AddContactHideBySceneSettingRequest();
        return TeaModel.build(map, self);
    }

    public AddContactHideBySceneSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AddContactHideBySceneSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public AddContactHideBySceneSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public AddContactHideBySceneSettingRequest setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public AddContactHideBySceneSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddContactHideBySceneSettingRequest setNodeListSceneConfig(AddContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig) {
        this.nodeListSceneConfig = nodeListSceneConfig;
        return this;
    }
    public AddContactHideBySceneSettingRequestNodeListSceneConfig getNodeListSceneConfig() {
        return this.nodeListSceneConfig;
    }

    public AddContactHideBySceneSettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public AddContactHideBySceneSettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public AddContactHideBySceneSettingRequest setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public AddContactHideBySceneSettingRequest setProfileSceneConfig(AddContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public AddContactHideBySceneSettingRequestProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public AddContactHideBySceneSettingRequest setSearchSceneConfig(AddContactHideBySceneSettingRequestSearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public AddContactHideBySceneSettingRequestSearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class AddContactHideBySceneSettingRequestNodeListSceneConfig extends TeaModel {
        /**
         * <p>是否在浏览组织架构与选人组件中生效，默认为true</p>
         */
        @NameInMap("active")
        public Boolean active;

        /**
         * <p>是否同时隐藏被隐藏部门下的员工，默认为true。如果为false，仅部门不可见，但是允许跳转到被隐藏部门查看部门下员工。</p>
         */
        @NameInMap("deptObjectIncludeEmp")
        public Boolean deptObjectIncludeEmp;

        public static AddContactHideBySceneSettingRequestNodeListSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            AddContactHideBySceneSettingRequestNodeListSceneConfig self = new AddContactHideBySceneSettingRequestNodeListSceneConfig();
            return TeaModel.build(map, self);
        }

        public AddContactHideBySceneSettingRequestNodeListSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public AddContactHideBySceneSettingRequestNodeListSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

    public static class AddContactHideBySceneSettingRequestProfileSceneConfig extends TeaModel {
        /**
         * <p>是否在用户详情页面生效，默认为true。如果为false，仍然允许查看个人资料页中的员工信息。</p>
         */
        @NameInMap("active")
        public Boolean active;

        public static AddContactHideBySceneSettingRequestProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            AddContactHideBySceneSettingRequestProfileSceneConfig self = new AddContactHideBySceneSettingRequestProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public AddContactHideBySceneSettingRequestProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class AddContactHideBySceneSettingRequestSearchSceneConfig extends TeaModel {
        /**
         * <p>是否在搜索场景生效，默认为true。如果为false，允许被搜索。</p>
         */
        @NameInMap("active")
        public Boolean active;

        /**
         * <p>是否同时隐藏被隐藏的部门下的员工，默认为true。如果为false，objectDeptIds中的部门无法被搜索，但是员工仍然可以被搜索</p>
         */
        @NameInMap("deptObjectIncludeEmp")
        public Boolean deptObjectIncludeEmp;

        public static AddContactHideBySceneSettingRequestSearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            AddContactHideBySceneSettingRequestSearchSceneConfig self = new AddContactHideBySceneSettingRequestSearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public AddContactHideBySceneSettingRequestSearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public AddContactHideBySceneSettingRequestSearchSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

}
