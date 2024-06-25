// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskInitRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>training</p>
     */
    @NameInMap("category")
    public String category;

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
     * <p>running</p>
     */
    @NameInMap("status")
    public String status;

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
