// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenObjectiveDTO extends TeaModel {
    @NameInMap("executor")
    public OpenUserDTO executor;

    @NameInMap("id")
    public String id;

    @NameInMap("keyResults")
    public java.util.List<OpenKeyResultDTO> keyResults;

    @NameInMap("period")
    public OpenPeriodDTO period;

    @NameInMap("progress")
    public Integer progress;

    @NameInMap("status")
    public Integer status;

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

    public OpenObjectiveDTO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public OpenObjectiveDTO setKeyResults(java.util.List<OpenKeyResultDTO> keyResults) {
        this.keyResults = keyResults;
        return this;
    }
    public java.util.List<OpenKeyResultDTO> getKeyResults() {
        return this.keyResults;
    }

    public OpenObjectiveDTO setPeriod(OpenPeriodDTO period) {
        this.period = period;
        return this;
    }
    public OpenPeriodDTO getPeriod() {
        return this.period;
    }

    public OpenObjectiveDTO setProgress(Integer progress) {
        this.progress = progress;
        return this;
    }
    public Integer getProgress() {
        return this.progress;
    }

    public OpenObjectiveDTO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
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
