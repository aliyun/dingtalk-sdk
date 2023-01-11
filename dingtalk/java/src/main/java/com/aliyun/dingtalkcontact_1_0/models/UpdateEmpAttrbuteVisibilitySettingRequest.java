// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttrbuteVisibilitySettingRequest extends TeaModel {
    /**
     * <p>是否生效</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <p>描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>例外部门id列表</p>
     */
    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    /**
     * <p>例外员工id列表</p>
     */
    @NameInMap("excludeStaffIds")
    public java.util.List<String> excludeStaffIds;

    /**
     * <p>例外角色id列表</p>
     */
    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    /**
     * <p>隐藏字段id列表</p>
     */
    @NameInMap("hideFields")
    public java.util.List<String> hideFields;

    /**
     * <p>id</p>
     */
    @NameInMap("id")
    public Long id;

    /**
     * <p>名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>object部门id列表</p>
     */
    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    /**
     * <p>object员工id列表</p>
     */
    @NameInMap("objectStaffIds")
    public java.util.List<String> objectStaffIds;

    /**
     * <p>object角色id列表</p>
     */
    @NameInMap("objectTagIds")
    public java.util.List<Long> objectTagIds;

    public static UpdateEmpAttrbuteVisibilitySettingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttrbuteVisibilitySettingRequest self = new UpdateEmpAttrbuteVisibilitySettingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setExcludeDeptIds(java.util.List<Long> excludeDeptIds) {
        this.excludeDeptIds = excludeDeptIds;
        return this;
    }
    public java.util.List<Long> getExcludeDeptIds() {
        return this.excludeDeptIds;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setExcludeStaffIds(java.util.List<String> excludeStaffIds) {
        this.excludeStaffIds = excludeStaffIds;
        return this;
    }
    public java.util.List<String> getExcludeStaffIds() {
        return this.excludeStaffIds;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setExcludeTagIds(java.util.List<Long> excludeTagIds) {
        this.excludeTagIds = excludeTagIds;
        return this;
    }
    public java.util.List<Long> getExcludeTagIds() {
        return this.excludeTagIds;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setHideFields(java.util.List<String> hideFields) {
        this.hideFields = hideFields;
        return this;
    }
    public java.util.List<String> getHideFields() {
        return this.hideFields;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setObjectDeptIds(java.util.List<Long> objectDeptIds) {
        this.objectDeptIds = objectDeptIds;
        return this;
    }
    public java.util.List<Long> getObjectDeptIds() {
        return this.objectDeptIds;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setObjectStaffIds(java.util.List<String> objectStaffIds) {
        this.objectStaffIds = objectStaffIds;
        return this;
    }
    public java.util.List<String> getObjectStaffIds() {
        return this.objectStaffIds;
    }

    public UpdateEmpAttrbuteVisibilitySettingRequest setObjectTagIds(java.util.List<Long> objectTagIds) {
        this.objectTagIds = objectTagIds;
        return this;
    }
    public java.util.List<Long> getObjectTagIds() {
        return this.objectTagIds;
    }

}
