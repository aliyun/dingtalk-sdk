// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactRestrictSettingRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <strong>example:</strong>
     * <p>rule description</p>
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
     * <p>1000</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <strong>example:</strong>
     * <p>contact restrict name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("restrictInSearch")
    public Boolean restrictInSearch;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("restrictInUserProfile")
    public Boolean restrictInUserProfile;

    @NameInMap("subjectDeptIds")
    public java.util.List<Long> subjectDeptIds;

    @NameInMap("subjectTagIds")
    public java.util.List<Long> subjectTagIds;

    @NameInMap("subjectUserIds")
    public java.util.List<String> subjectUserIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public String type;

    public static UpdateContactRestrictSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactRestrictSettingRequest self = new UpdateContactRestrictSettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateContactRestrictSettingRequest setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public UpdateContactRestrictSettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateContactRestrictSettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public UpdateContactRestrictSettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public UpdateContactRestrictSettingRequest setExcludeUserIds(java.util.List<String> excludeUserIds) {
        this.excludeUserIds = excludeUserIds;
        return this;
    }
    public java.util.List<String> getExcludeUserIds() {
        return this.excludeUserIds;
    }

    public UpdateContactRestrictSettingRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateContactRestrictSettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateContactRestrictSettingRequest setRestrictInSearch(Boolean restrictInSearch) {
        this.restrictInSearch = restrictInSearch;
        return this;
    }
    public Boolean getRestrictInSearch() {
        return this.restrictInSearch;
    }

    public UpdateContactRestrictSettingRequest setRestrictInUserProfile(Boolean restrictInUserProfile) {
        this.restrictInUserProfile = restrictInUserProfile;
        return this;
    }
    public Boolean getRestrictInUserProfile() {
        return this.restrictInUserProfile;
    }

    public UpdateContactRestrictSettingRequest setSubjectDeptIds(java.util.List<Long> subjectDeptIds) {
        this.subjectDeptIds = subjectDeptIds;
        return this;
    }
    public java.util.List<Long> getSubjectDeptIds() {
        return this.subjectDeptIds;
    }

    public UpdateContactRestrictSettingRequest setSubjectTagIds(java.util.List<Long> subjectTagIds) {
        this.subjectTagIds = subjectTagIds;
        return this;
    }
    public java.util.List<Long> getSubjectTagIds() {
        return this.subjectTagIds;
    }

    public UpdateContactRestrictSettingRequest setSubjectUserIds(java.util.List<String> subjectUserIds) {
        this.subjectUserIds = subjectUserIds;
        return this;
    }
    public java.util.List<String> getSubjectUserIds() {
        return this.subjectUserIds;
    }

    public UpdateContactRestrictSettingRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
