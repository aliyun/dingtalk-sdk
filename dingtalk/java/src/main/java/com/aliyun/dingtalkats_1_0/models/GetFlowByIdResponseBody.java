// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFlowByIdResponseBody extends TeaModel {
    @NameInMap("candidateId")
    public String candidateId;

    @NameInMap("candidateName")
    public String candidateName;

    @NameInMap("createTime")
    public Long createTime;

    @NameInMap("currentStatus")
    public String currentStatus;

    @NameInMap("flowId")
    public String flowId;

    @NameInMap("jobId")
    public String jobId;

    @NameInMap("sourceName")
    public String sourceName;

    @NameInMap("statId")
    public String statId;

    public static GetFlowByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlowByIdResponseBody self = new GetFlowByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlowByIdResponseBody setCandidateId(String candidateId) {
        this.candidateId = candidateId;
        return this;
    }
    public String getCandidateId() {
        return this.candidateId;
    }

    public GetFlowByIdResponseBody setCandidateName(String candidateName) {
        this.candidateName = candidateName;
        return this;
    }
    public String getCandidateName() {
        return this.candidateName;
    }

    public GetFlowByIdResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetFlowByIdResponseBody setCurrentStatus(String currentStatus) {
        this.currentStatus = currentStatus;
        return this;
    }
    public String getCurrentStatus() {
        return this.currentStatus;
    }

    public GetFlowByIdResponseBody setFlowId(String flowId) {
        this.flowId = flowId;
        return this;
    }
    public String getFlowId() {
        return this.flowId;
    }

    public GetFlowByIdResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

    public GetFlowByIdResponseBody setSourceName(String sourceName) {
        this.sourceName = sourceName;
        return this;
    }
    public String getSourceName() {
        return this.sourceName;
    }

    public GetFlowByIdResponseBody setStatId(String statId) {
        this.statId = statId;
        return this;
    }
    public String getStatId() {
        return this.statId;
    }

}
