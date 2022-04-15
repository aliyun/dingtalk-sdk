// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskInitRequest extends TeaModel {
    // 任务业务模块，如training, performance等
    @NameInMap("category")
    public String category;

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

    // 任务状态，如running,finished
    @NameInMap("status")
    public String status;

    // 任务名称
    @NameInMap("title")
    public String title;

    // 任务执行人userId
    @NameInMap("userId")
    public String userId;

    // 解决方案类型
    @NameInMap("solutionType")
    public String solutionType;

    public static SolutionTaskInitRequest build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskInitRequest self = new SolutionTaskInitRequest();
        return TeaModel.build(map, self);
    }

    public SolutionTaskInitRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public SolutionTaskInitRequest setClaimTime(Long claimTime) {
        this.claimTime = claimTime;
        return this;
    }
    public Long getClaimTime() {
        return this.claimTime;
    }

    public SolutionTaskInitRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SolutionTaskInitRequest setFinishTime(Long finishTime) {
        this.finishTime = finishTime;
        return this;
    }
    public Long getFinishTime() {
        return this.finishTime;
    }

    public SolutionTaskInitRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public SolutionTaskInitRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SolutionTaskInitRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SolutionTaskInitRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SolutionTaskInitRequest setSolutionType(String solutionType) {
        this.solutionType = solutionType;
        return this;
    }
    public String getSolutionType() {
        return this.solutionType;
    }

}
