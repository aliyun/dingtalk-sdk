// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactRestrictSettingRequest extends TeaModel {
    /**
     * <p>是否生效</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <p>规则描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>白名单deptId列表</p>
     */
    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    /**
     * <p>白名单tagId列表</p>
     */
    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    /**
     * <p>白名单userid列表</p>
     */
    @NameInMap("excludeUserIds")
    public java.util.List<String> excludeUserIds;

    /**
     * <p>id</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>规则名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>是否同时限制搜索</p>
     */
    @NameInMap("restrictInSearch")
    public Boolean restrictInSearch;

    /**
     * <p>是否同时限制查看个人资料页</p>
     */
    @NameInMap("restrictInUserProfile")
    public Boolean restrictInUserProfile;

    /**
     * <p>主体的部门id列表</p>
     */
    @NameInMap("subjectDeptIds")
    public java.util.List<Long> subjectDeptIds;

    /**
     * <p>主体的角色id列表</p>
     */
    @NameInMap("subjectTagIds")
    public java.util.List<Long> subjectTagIds;

    /**
     * <p>主体的userId列表</p>
     */
    @NameInMap("subjectUserIds")
    public java.util.List<String> subjectUserIds;

    /**
     * <p>限制类型</p>
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
