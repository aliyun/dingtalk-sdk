// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdateAutoIssuePointRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pointAutoNum")
    public Long pointAutoNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("pointAutoState")
    public Boolean pointAutoState;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15</p>
     */
    @NameInMap("pointAutoTime")
    public Long pointAutoTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11185568-1380470824</p>
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
