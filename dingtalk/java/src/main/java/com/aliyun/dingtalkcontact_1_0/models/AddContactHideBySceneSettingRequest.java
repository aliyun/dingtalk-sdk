// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddContactHideBySceneSettingRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    @NameInMap("excludeUserIds")
    public java.util.List<String> excludeUserIds;

    @NameInMap("name")
    public String name;

    @NameInMap("nodeListSceneConfig")
    public AddContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig;

    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    @NameInMap("objectUserIds")
    public java.util.List<String> objectUserIds;

    @NameInMap("profileSceneConfig")
    public AddContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

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
        @NameInMap("active")
        public Boolean active;

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
        @NameInMap("active")
        public Boolean active;

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
