// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalObjectiveDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("executor")
    public OpenAgoalUserDTO executor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("keyActions")
    public java.util.List<OpenAgoalKeyActionDTO> keyActions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("keyResults")
    public java.util.List<OpenAgoalKeyResultDTO> keyResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("latestProgress")
    public OpenAgoalLatestProgressDTO latestProgress;

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
    @NameInMap("objectiveRule")
    public OpenOrgObjectiveRuleDTO objectiveRule;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("period")
    public OpenObjectiveRulePeriodDTO period;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("progress")
    public Integer progress;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relatedUsers")
    public OpenAgoalUserDTO relatedUsers;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teams")
    public java.util.List<OpenAgoalTeamDTO> teams;

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
     * 
     * <strong>example:</strong>
     * <p>30</p>
     */
    @NameInMap("weight")
    public Double weight;

    public static OpenAgoalObjectiveDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalObjectiveDTO self = new OpenAgoalObjectiveDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalObjectiveDTO setExecutor(OpenAgoalUserDTO executor) {
        this.executor = executor;
        return this;
    }
    public OpenAgoalUserDTO getExecutor() {
        return this.executor;
    }

    public OpenAgoalObjectiveDTO setKeyActions(java.util.List<OpenAgoalKeyActionDTO> keyActions) {
        this.keyActions = keyActions;
        return this;
    }
    public java.util.List<OpenAgoalKeyActionDTO> getKeyActions() {
        return this.keyActions;
    }

    public OpenAgoalObjectiveDTO setKeyResults(java.util.List<OpenAgoalKeyResultDTO> keyResults) {
        this.keyResults = keyResults;
        return this;
    }
    public java.util.List<OpenAgoalKeyResultDTO> getKeyResults() {
        return this.keyResults;
    }

    public OpenAgoalObjectiveDTO setLatestProgress(OpenAgoalLatestProgressDTO latestProgress) {
        this.latestProgress = latestProgress;
        return this;
    }
    public OpenAgoalLatestProgressDTO getLatestProgress() {
        return this.latestProgress;
    }

    public OpenAgoalObjectiveDTO setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public OpenAgoalObjectiveDTO setObjectiveRule(OpenOrgObjectiveRuleDTO objectiveRule) {
        this.objectiveRule = objectiveRule;
        return this;
    }
    public OpenOrgObjectiveRuleDTO getObjectiveRule() {
        return this.objectiveRule;
    }

    public OpenAgoalObjectiveDTO setPeriod(OpenObjectiveRulePeriodDTO period) {
        this.period = period;
        return this;
    }
    public OpenObjectiveRulePeriodDTO getPeriod() {
        return this.period;
    }

    public OpenAgoalObjectiveDTO setProgress(Integer progress) {
        this.progress = progress;
        return this;
    }
    public Integer getProgress() {
        return this.progress;
    }

    public OpenAgoalObjectiveDTO setRelatedUsers(OpenAgoalUserDTO relatedUsers) {
        this.relatedUsers = relatedUsers;
        return this;
    }
    public OpenAgoalUserDTO getRelatedUsers() {
        return this.relatedUsers;
    }

    public OpenAgoalObjectiveDTO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public OpenAgoalObjectiveDTO setTeams(java.util.List<OpenAgoalTeamDTO> teams) {
        this.teams = teams;
        return this;
    }
    public java.util.List<OpenAgoalTeamDTO> getTeams() {
        return this.teams;
    }

    public OpenAgoalObjectiveDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalObjectiveDTO setWeight(Double weight) {
        this.weight = weight;
        return this;
    }
    public Double getWeight() {
        return this.weight;
    }

}
