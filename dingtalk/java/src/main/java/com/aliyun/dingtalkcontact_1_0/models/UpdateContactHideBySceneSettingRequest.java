// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideBySceneSettingRequest extends TeaModel {
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

    /**
     * <strong>example:</strong>
     * <p>test name</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("nodeListSceneConfig")
    public UpdateContactHideBySceneSettingRequestNodeListSceneConfig nodeListSceneConfig;

    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    @NameInMap("objectUserIds")
    public java.util.List<String> objectUserIds;

    @NameInMap("profileSceneConfig")
    public UpdateContactHideBySceneSettingRequestProfileSceneConfig profileSceneConfig;

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
        @NameInMap("active")
        public Boolean active;

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
        @NameInMap("active")
        public Boolean active;

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
