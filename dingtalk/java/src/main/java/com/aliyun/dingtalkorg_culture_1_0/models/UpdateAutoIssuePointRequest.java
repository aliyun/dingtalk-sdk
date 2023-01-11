// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdateAutoIssuePointRequest extends TeaModel {
    /**
     * <p>企业积分自动发放数量1-10000</p>
     */
    @NameInMap("pointAutoNum")
    public Long pointAutoNum;

    /**
     * <p>企业积分自动发放状态</p>
     */
    @NameInMap("pointAutoState")
    public Boolean pointAutoState;

    /**
     * <p>企业积分自动发放时间 必须为每月的1号或15号，传入1时为1号，传入15时为15号。</p>
     */
    @NameInMap("pointAutoTime")
    public Long pointAutoTime;

    /**
     * <p>操作人userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateAutoIssuePointRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAutoIssuePointRequest self = new UpdateAutoIssuePointRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAutoIssuePointRequest setPointAutoNum(Long pointAutoNum) {
        this.pointAutoNum = pointAutoNum;
        return this;
    }
    public Long getPointAutoNum() {
        return this.pointAutoNum;
    }

    public UpdateAutoIssuePointRequest setPointAutoState(Boolean pointAutoState) {
        this.pointAutoState = pointAutoState;
        return this;
    }
    public Boolean getPointAutoState() {
        return this.pointAutoState;
    }

    public UpdateAutoIssuePointRequest setPointAutoTime(Long pointAutoTime) {
        this.pointAutoTime = pointAutoTime;
        return this;
    }
    public Long getPointAutoTime() {
        return this.pointAutoTime;
    }

    public UpdateAutoIssuePointRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
