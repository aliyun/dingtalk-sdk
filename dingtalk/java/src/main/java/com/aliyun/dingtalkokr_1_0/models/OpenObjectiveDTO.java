// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveDTO extends TeaModel {
    @NameInMap("executor")
    public OpenUserDTO executor;

    @NameInMap("keyResults")
    public java.util.List<OpenKeyResultDTO> keyResults;

    @NameInMap("objectiveId")
    public String objectiveId;

    @NameInMap("period")
    public OpenPeriodDTO period;

    @NameInMap("progress")
    public Long progress;

    @NameInMap("status")
    public Long status;

    @NameInMap("teams")
    public java.util.List<OpenTeamDTO> teams;

    @NameInMap("title")
    public String title;

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

}
