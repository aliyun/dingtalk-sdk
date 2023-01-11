// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideSettingRequest extends TeaModel {
    /**
     * <p>是否激活</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <p>设置描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>白名单部门列表</p>
     */
    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    /**
     * <p>白名单员工列表</p>
     */
    @NameInMap("excludeStaffIds")
    public java.util.List<String> excludeStaffIds;

    /**
     * <p>白名单角色列表</p>
     */
    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    /**
     * <p>是否同时在被搜索时隐藏</p>
     */
    @NameInMap("hideInSearch")
    public Boolean hideInSearch;

    /**
     * <p>是否同时在被查看个人资料页时隐藏</p>
     */
    @NameInMap("hideInUserProfile")
    public Boolean hideInUserProfile;

    /**
     * <p>settingId</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>设置名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>影藏部门列表</p>
     */
    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    /**
     * <p>隐藏员工列表</p>
     */
    @NameInMap("objectStaffIds")
    public java.util.List<String> objectStaffIds;

    /**
     * <p>影藏角色列表</p>
     */
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
