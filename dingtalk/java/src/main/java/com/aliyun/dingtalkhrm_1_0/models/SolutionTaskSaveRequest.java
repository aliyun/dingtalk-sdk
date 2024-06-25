// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskSaveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>时间戳</p>
     */
    @NameInMap("claimTime")
    public Long claimTime;

    /**
     * <strong>example:</strong>
     * <p>这是一个新人培训任务</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>时间戳</p>
     */
    @NameInMap("finishTime")
    public Long finishTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fdagshfjhajl</p>
     */
    @NameInMap("outerId")
    public String outerId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qweqweqwe</p>
     */
    @NameInMap("solutionInstanceId")
    public String solutionInstanceId;

    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>running</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PERFORMANCE_TASK、TRAIN_TASK</p>
     */
    @NameInMap("taskType")
    public String taskType;

    /**
     * <strong>example:</strong>
     * <p>sdfasd2323sdaf</p>
     */
    @NameInMap("templateOuterId")
    public String templateOuterId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>新人学习任务</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>onboarding</p>
     */
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
