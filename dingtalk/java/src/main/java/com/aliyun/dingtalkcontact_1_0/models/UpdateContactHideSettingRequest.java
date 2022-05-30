// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideSettingRequest extends TeaModel {
    // 是否激活
    @NameInMap("active")
    public Boolean active;

    // 设置描述信息
    @NameInMap("description")
    public String description;

    // 白名单部门列表
    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    // 白名单员工列表
    @NameInMap("excludeStaffIds")
    public java.util.List<String> excludeStaffIds;

    // 白名单角色列表
    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    // 是否同时在被搜索时隐藏
    @NameInMap("hideInSearch")
    public Boolean hideInSearch;

    // 是否同时在被查看个人资料页时隐藏
    @NameInMap("hideInUserProfile")
    public Boolean hideInUserProfile;

    // settingId
    @NameInMap("id")
    public Long id;

    // 设置名称
    @NameInMap("name")
    public String name;

    // 影藏部门列表
    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    // 隐藏员工列表
    @NameInMap("objectStaffIds")
    public java.util.List<String> objectStaffIds;

    // 影藏角色列表
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
