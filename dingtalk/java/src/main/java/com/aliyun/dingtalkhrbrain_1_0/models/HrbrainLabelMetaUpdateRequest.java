// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaUpdateRequest extends TeaModel {
    @NameInMap("categoryCode")
    public String categoryCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("dataType")
    public String dataType;

    @NameInMap("description")
    public String description;

    @NameInMap("importantLevel")
    public String importantLevel;

    @NameInMap("isSensitive")
    public Boolean isSensitive;

    @NameInMap("name")
    public String name;

    @NameInMap("options")
    public java.util.List<java.util.Map<String, ?>> options;

    @NameInMap("permission")
    public java.util.Map<String, ?> permission;

    @NameInMap("required")
    public Boolean required;

    public static HrbrainLabelMetaUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaUpdateRequest self = new HrbrainLabelMetaUpdateRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaUpdateRequest setCategoryCode(String categoryCode) {
        this.categoryCode = categoryCode;
        return this;
    }
    public String getCategoryCode() {
        return this.categoryCode;
    }

    public HrbrainLabelMetaUpdateRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public HrbrainLabelMetaUpdateRequest setDataType(String dataType) {
        this.dataType = dataType;
        return this;
    }
    public String getDataType() {
        return this.dataType;
    }

    public HrbrainLabelMetaUpdateRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public HrbrainLabelMetaUpdateRequest setImportantLevel(String importantLevel) {
        this.importantLevel = importantLevel;
        return this;
    }
    public String getImportantLevel() {
        return this.importantLevel;
    }

    public HrbrainLabelMetaUpdateRequest setIsSensitive(Boolean isSensitive) {
        this.isSensitive = isSensitive;
        return this;
    }
    public Boolean getIsSensitive() {
        return this.isSensitive;
    }

    public HrbrainLabelMetaUpdateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public HrbrainLabelMetaUpdateRequest setOptions(java.util.List<java.util.Map<String, ?>> options) {
        this.options = options;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getOptions() {
        return this.options;
    }

    public HrbrainLabelMetaUpdateRequest setPermission(java.util.Map<String, ?> permission) {
        this.permission = permission;
        return this;
    }
    public java.util.Map<String, ?> getPermission() {
        return this.permission;
    }

    public HrbrainLabelMetaUpdateRequest setRequired(Boolean required) {
        this.required = required;
        return this;
    }
    public Boolean getRequired() {
        return this.required;
    }

}
