// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalObjectiveDimensionDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("children")
    public java.util.List<OpenAgoalObjectiveDimensionDTOChildren> children;

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

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>这是维度标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("weight")
    public Double weight;

    public static OpenAgoalObjectiveDimensionDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalObjectiveDimensionDTO self = new OpenAgoalObjectiveDimensionDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalObjectiveDimensionDTO setChildren(java.util.List<OpenAgoalObjectiveDimensionDTOChildren> children) {
        this.children = children;
        return this;
    }
    public java.util.List<OpenAgoalObjectiveDimensionDTOChildren> getChildren() {
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

    public OpenAgoalObjectiveDimensionDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalObjectiveDimensionDTO setWeight(Double weight) {
        this.weight = weight;
        return this;
    }
    public Double getWeight() {
        return this.weight;
    }

    public static class OpenAgoalObjectiveDimensionDTOChildren extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>662e006fe4b0f57ccbcxxxxx</p>
         */
        @NameInMap("dimensionId")
        public String dimensionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>这是子维度标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("weight")
        public Double weight;

        public static OpenAgoalObjectiveDimensionDTOChildren build(java.util.Map<String, ?> map) throws Exception {
            OpenAgoalObjectiveDimensionDTOChildren self = new OpenAgoalObjectiveDimensionDTOChildren();
            return TeaModel.build(map, self);
        }

        public OpenAgoalObjectiveDimensionDTOChildren setDimensionId(String dimensionId) {
            this.dimensionId = dimensionId;
            return this;
        }
        public String getDimensionId() {
            return this.dimensionId;
        }

        public OpenAgoalObjectiveDimensionDTOChildren setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public OpenAgoalObjectiveDimensionDTOChildren setWeight(Double weight) {
            this.weight = weight;
            return this;
        }
        public Double getWeight() {
            return this.weight;
        }

    }

}
