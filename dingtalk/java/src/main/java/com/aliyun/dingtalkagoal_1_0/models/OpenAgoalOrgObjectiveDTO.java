// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalOrgObjectiveDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dimension")
    public OpenAgoalObjectiveDimensionDTO dimension;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("downAlignObjects")
    public java.util.List<OpenAgoalAlignDTO> downAlignObjects;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("executor")
    public OpenAgoalUserDTO executor;

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
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("period")
    public OpenObjectiveRulePeriodDTO period;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("team")
    public OpenAgoalTeamDTO team;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试目标</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("upAlignObjects")
    public java.util.List<OpenAgoalAlignDTO> upAlignObjects;

    public static OpenAgoalOrgObjectiveDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalOrgObjectiveDTO self = new OpenAgoalOrgObjectiveDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalOrgObjectiveDTO setDimension(OpenAgoalObjectiveDimensionDTO dimension) {
        this.dimension = dimension;
        return this;
    }
    public OpenAgoalObjectiveDimensionDTO getDimension() {
        return this.dimension;
    }

    public OpenAgoalOrgObjectiveDTO setDownAlignObjects(java.util.List<OpenAgoalAlignDTO> downAlignObjects) {
        this.downAlignObjects = downAlignObjects;
        return this;
    }
    public java.util.List<OpenAgoalAlignDTO> getDownAlignObjects() {
        return this.downAlignObjects;
    }

    public OpenAgoalOrgObjectiveDTO setExecutor(OpenAgoalUserDTO executor) {
        this.executor = executor;
        return this;
    }
    public OpenAgoalUserDTO getExecutor() {
        return this.executor;
    }

    public OpenAgoalOrgObjectiveDTO setFieldConfig(java.util.List<OpenAgoalFieldMetaDTO> fieldConfig) {
        this.fieldConfig = fieldConfig;
        return this;
    }
    public java.util.List<OpenAgoalFieldMetaDTO> getFieldConfig() {
        return this.fieldConfig;
    }

    public OpenAgoalOrgObjectiveDTO setFieldValueMap(java.util.Map<String, ?> fieldValueMap) {
        this.fieldValueMap = fieldValueMap;
        return this;
    }
    public java.util.Map<String, ?> getFieldValueMap() {
        return this.fieldValueMap;
    }

    public OpenAgoalOrgObjectiveDTO setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public OpenAgoalOrgObjectiveDTO setPeriod(OpenObjectiveRulePeriodDTO period) {
        this.period = period;
        return this;
    }
    public OpenObjectiveRulePeriodDTO getPeriod() {
        return this.period;
    }

    public OpenAgoalOrgObjectiveDTO setTeam(OpenAgoalTeamDTO team) {
        this.team = team;
        return this;
    }
    public OpenAgoalTeamDTO getTeam() {
        return this.team;
    }

    public OpenAgoalOrgObjectiveDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalOrgObjectiveDTO setUpAlignObjects(java.util.List<OpenAgoalAlignDTO> upAlignObjects) {
        this.upAlignObjects = upAlignObjects;
        return this;
    }
    public java.util.List<OpenAgoalAlignDTO> getUpAlignObjects() {
        return this.upAlignObjects;
    }

}
