// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideSettingRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <strong>example:</strong>
     * <p>description text</p>
     */
    @NameInMap("description")
    public String description;

    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    @NameInMap("excludeStaffIds")
    public java.util.List<String> excludeStaffIds;

    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("hideInSearch")
    public Boolean hideInSearch;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("hideInUserProfile")
    public Boolean hideInUserProfile;

    /**
     * <strong>example:</strong>
     * <p>11234</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <strong>example:</strong>
     * <p>test name</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    @NameInMap("objectStaffIds")
    public java.util.List<String> objectStaffIds;

    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    public static UpdateContactHideSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideSettingRequest self = new UpdateContactHideSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideSettingRequest setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public UpdateContactHideSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateContactHideSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public UpdateContactHideSettingRequest setExcludeStaffIds(java.util.List<String> excludeStaffIds) {
        this.excludeStaffIds = excludeStaffIds;
        return this;
    }
    public java.util.List<String> getExcludeStaffIds() {
        return this.excludeStaffIds;
    }

    public UpdateContactHideSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public UpdateContactHideSettingRequest setHideInSearch(Boolean hideInSearch) {
        this.hideInSearch = hideInSearch;
        return this;
    }
    public Boolean getHideInSearch() {
        return this.hideInSearch;
    }

    public UpdateContactHideSettingRequest setHideInUserProfile(Boolean hideInUserProfile) {
        this.hideInUserProfile = hideInUserProfile;
        return this;
    }
    public Boolean getHideInUserProfile() {
        return this.hideInUserProfile;
    }

    public UpdateContactHideSettingRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateContactHideSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateContactHideSettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public UpdateContactHideSettingRequest setObjectStaffIds(java.util.List<String> objectStaffIds) {
        this.objectStaffIds = objectStaffIds;
        return this;
    }
    public java.util.List<String> getObjectStaffIds() {
        return this.objectStaffIds;
    }

    public UpdateContactHideSettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

}
