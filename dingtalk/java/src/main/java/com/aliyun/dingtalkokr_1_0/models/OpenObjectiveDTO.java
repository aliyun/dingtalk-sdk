// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveDTO extends TeaModel {
    @NameInMap("executor")
    public OpenUserDTO executor;

    @NameInMap("keyResults")
    public java.util.List<OpenKeyResultDTO> keyResults;

    /**
     * <strong>example:</strong>
     * <p>65222640d0e8b868f9f9ae3c</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    @NameInMap("period")
    public OpenPeriodDTO period;

    /**
     * <strong>example:</strong>
     * <p>80</p>
     */
    @NameInMap("progress")
    public Long progress;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Long status;

    @NameInMap("teams")
    public java.util.List<OpenTeamDTO> teams;

    /**
     * <strong>example:</strong>
     * <p>这是一个O的标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>10.00</p>
     */
    @NameInMap("weight")
    public Double weight;

    public static OpenObjectiveDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenObjectiveDTO self = new OpenObjectiveDTO();
        return TeaModel.build(map, self);
    }

    public OpenObjectiveDTO setExecutor(OpenUserDTO executor) {
        this.executor = executor;
        return this;
    }
    public OpenUserDTO getExecutor() {
        return this.executor;
    }

    public OpenObjectiveDTO setKeyResults(java.util.List<OpenKeyResultDTO> keyResults) {
        this.keyResults = keyResults;
        return this;
    }
    public java.util.List<OpenKeyResultDTO> getKeyResults() {
        return this.keyResults;
    }

    public OpenObjectiveDTO setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public OpenObjectiveDTO setPeriod(OpenPeriodDTO period) {
        this.period = period;
        return this;
    }
    public OpenPeriodDTO getPeriod() {
        return this.period;
    }

    public OpenObjectiveDTO setProgress(Long progress) {
        this.progress = progress;
        return this;
    }
    public Long getProgress() {
        return this.progress;
    }

    public OpenObjectiveDTO setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public OpenObjectiveDTO setTeams(java.util.List<OpenTeamDTO> teams) {
        this.teams = teams;
        return this;
    }
    public java.util.List<OpenTeamDTO> getTeams() {
        return this.teams;
    }

    public OpenObjectiveDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenObjectiveDTO setWeight(Double weight) {
        this.weight = weight;
        return this;
    }
    public Double getWeight() {
        return this.weight;
    }

}
