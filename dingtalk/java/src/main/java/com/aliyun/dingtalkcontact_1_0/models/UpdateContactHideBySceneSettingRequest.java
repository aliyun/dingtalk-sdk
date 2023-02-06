// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideBySceneSettingRequest extends TeaModel {
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
    public UpdateContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig;

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
    public UpdateContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

    /**
     * <p>搜索的场景配置（包括搜索部门、搜索员工）</p>
     */
    @NameInMap("searchSceneConfig")
    public UpdateContactHideBySceneSettingRequestSearchSceneConfig searchSceneConfig;

    public static UpdateContactHideBySceneSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideBySceneSettingRequest self = new UpdateContactHideBySceneSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideBySceneSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateContactHideBySceneSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public UpdateContactHideBySceneSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public UpdateContactHideBySceneSettingRequest setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public UpdateContactHideBySceneSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateContactHideBySceneSettingRequest setNodeListSceneConfig(UpdateContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig) {
        this.nodeListSceneConfig = nodeListSceneConfig;
        return this;
    }
    public UpdateContactHideBySceneSettingRequestNodeListSceneConfig getNodeListSceneConfig() {
        return this.nodeListSceneConfig;
    }

    public UpdateContactHideBySceneSettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public UpdateContactHideBySceneSettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

    public UpdateContactHideBySceneSettingRequest setObjectUserIds(java.util.List<String> objectUserIds) {
        this.objectUserIds = objectUserIds;
        return this;
    }
    public java.util.List<String> getObjectUserIds() {
        return this.objectUserIds;
    }

    public UpdateContactHideBySceneSettingRequest setProfileSceneConfig(UpdateContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig) {
        this.profileSceneConfig = profileSceneConfig;
        return this;
    }
    public UpdateContactHideBySceneSettingRequestProfileSceneConfig getProfileSceneConfig() {
        return this.profileSceneConfig;
    }

    public UpdateContactHideBySceneSettingRequest setSearchSceneConfig(UpdateContactHideBySceneSettingRequestSearchSceneConfig searchSceneConfig) {
        this.searchSceneConfig = searchSceneConfig;
        return this;
    }
    public UpdateContactHideBySceneSettingRequestSearchSceneConfig getSearchSceneConfig() {
        return this.searchSceneConfig;
    }

    public static class UpdateContactHideBySceneSettingRequestNodeListSceneConfig extends TeaModel {
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

        public static UpdateContactHideBySceneSettingRequestNodeListSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateContactHideBySceneSettingRequestNodeListSceneConfig self = new UpdateContactHideBySceneSettingRequestNodeListSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateContactHideBySceneSettingRequestNodeListSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public UpdateContactHideBySceneSettingRequestNodeListSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

    public static class UpdateContactHideBySceneSettingRequestProfileSceneConfig extends TeaModel {
        /**
         * <p>是否在用户详情页面生效，默认为true。如果为false，仍然允许查看个人资料页中的员工信息。</p>
         */
        @NameInMap("active")
        public Boolean active;

        public static UpdateContactHideBySceneSettingRequestProfileSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateContactHideBySceneSettingRequestProfileSceneConfig self = new UpdateContactHideBySceneSettingRequestProfileSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateContactHideBySceneSettingRequestProfileSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

    }

    public static class UpdateContactHideBySceneSettingRequestSearchSceneConfig extends TeaModel {
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

        public static UpdateContactHideBySceneSettingRequestSearchSceneConfig build(java.util.Map<String, ?> map) throws Exception {
            UpdateContactHideBySceneSettingRequestSearchSceneConfig self = new UpdateContactHideBySceneSettingRequestSearchSceneConfig();
            return TeaModel.build(map, self);
        }

        public UpdateContactHideBySceneSettingRequestSearchSceneConfig setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public UpdateContactHideBySceneSettingRequestSearchSceneConfig setDeptObjectIncludeEmp(Boolean deptObjectIncludeEmp) {
            this.deptObjectIncludeEmp = deptObjectIncludeEmp;
            return this;
        }
        public Boolean getDeptObjectIncludeEmp() {
            return this.deptObjectIncludeEmp;
        }

    }

}
