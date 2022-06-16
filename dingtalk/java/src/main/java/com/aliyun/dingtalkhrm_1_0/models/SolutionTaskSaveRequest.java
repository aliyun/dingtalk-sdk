// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskSaveRequest extends TeaModel {
    // 任务要求的截止时间
    @NameInMap("claimTime")
    public Long claimTime;

    // 任务描述
    @NameInMap("description")
    public String description;

    // 任务完成时间
    @NameInMap("finishTime")
    public Long finishTime;

    // 外部的任务唯一标识
    @NameInMap("outerId")
    public String outerId;

    @NameInMap("solutionInstanceId")
    public String solutionInstanceId;

    @NameInMap("startTime")
    public Long startTime;

    // 任务状态，如running,finished
    @NameInMap("status")
    public String status;

    // 任务业务模块，如training, performance等
    @NameInMap("taskType")
    public String taskType;

    @NameInMap("templateOuterId")
    public String templateOuterId;

    // 任务名称
    @NameInMap("title")
    public String title;

    // 任务执行人userId
    @NameInMap("userId")
    public String userId;

    // 解决方案类型
    @NameInMap("solutionType")
    public String solutionType;

    public static SolutionTaskSaveRequest build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskSaveRequest self = new SolutionTaskSaveRequest();
        return TeaModel.build(map, self);
    }

    public SolutionTaskSaveRequest setClaimTime(Long claimTime) {
        this.claimTime = claimTime;
        return this;
    }
    public Long getClaimTime() {
        return this.claimTime;
    }

    public SolutionTaskSaveRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SolutionTaskSaveRequest setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public SolutionTaskSaveRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public SolutionTaskSaveRequest setSolutionInstanceId(String solutionInstanceId) {
        this.solutionInstanceId = solutionInstanceId;
        return this;
    }
    public String getSolutionInstanceId() {
        return this.solutionInstanceId;
    }

    public SolutionTaskSaveRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public SolutionTaskSaveRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SolutionTaskSaveRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public SolutionTaskSaveRequest setTemplateOuterId(String templateOuterId) {
        this.templateOuterId = templateOuterId;
        return this;
    }
    public String getTemplateOuterId() {
        return this.templateOuterId;
    }

    public SolutionTaskSaveRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SolutionTaskSaveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SolutionTaskSaveRequest setSolutionType(String solutionType) {
        this.solutionType = solutionType;
        return this;
    }
    public String getSolutionType() {
        return this.solutionType;
    }

}
