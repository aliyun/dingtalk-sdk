// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttrbuteVisibilitySettingRequest extends TeaModel {
    @NameInMap("active")
    public Boolean active;

    @NameInMap("description")
    public String description;

    @NameInMap("excludeDeptIds")
    public java.util.List<Long> excludeDeptIds;

    @NameInMap("excludeStaffIds")
    public java.util.List<String> excludeStaffIds;

    @NameInMap("excludeTagIds")
    public java.util.List<Long> excludeTagIds;

    @NameInMap("hideFields")
    public java.util.List<String> hideFields;

    /**
     * <strong>example:</strong>
     * <p>11111</p>
     */
    @NameInMap("id")
    public Long id;

    @NameInMap("name")
    public String name;

    @NameInMap("objectDeptIds")
    public java.util.List<Long> objectDeptIds;

    @NameInMap("objectStaffIds")
    public java.util.List<String> objectStaffIds;

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
