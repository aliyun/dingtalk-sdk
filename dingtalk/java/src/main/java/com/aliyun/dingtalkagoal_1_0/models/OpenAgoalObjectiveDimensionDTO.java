// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalObjectiveDimensionDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("children")
    public java.util.List<OpenAgoalObjectiveDimensionDTO> children;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     */
    @NameInMap("dimensionId")
    public String dimensionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldConfig")
    public java.util.List<OpenAgoalFieldMetaDTO> fieldConfig;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldValueMap")
    public java.util.Map<String, ?> fieldValueMap;

    public static OpenAgoalObjectiveDimensionDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalObjectiveDimensionDTO self = new OpenAgoalObjectiveDimensionDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalObjectiveDimensionDTO setChildren(java.util.List<OpenAgoalObjectiveDimensionDTO> children) {
        this.children = children;
        return this;
    }
    public java.util.List<OpenAgoalObjectiveDimensionDTO> getChildren() {
        return this.children;
    }

    public OpenAgoalObjectiveDimensionDTO setDimensionId(String dimensionId) {
        this.dimensionId = dimensionId;
        return this;
    }
    public String getDimensionId() {
        return this.dimensionId;
    }

    public OpenAgoalObjectiveDimensionDTO setFieldConfig(java.util.List<OpenAgoalFieldMetaDTO> fieldConfig) {
        this.fieldConfig = fieldConfig;
        return this;
    }
    public java.util.List<OpenAgoalFieldMetaDTO> getFieldConfig() {
        return this.fieldConfig;
    }

    public OpenAgoalObjectiveDimensionDTO setFieldValueMap(java.util.Map<String, ?> fieldValueMap) {
        this.fieldValueMap = fieldValueMap;
        return this;
    }
    public java.util.Map<String, ?> getFieldValueMap() {
        return this.fieldValueMap;
    }

}
