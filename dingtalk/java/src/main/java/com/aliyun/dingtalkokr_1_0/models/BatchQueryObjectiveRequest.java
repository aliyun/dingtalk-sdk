// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveIds")
    public java.util.List<String> objectiveIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10056</p>
     */
    @NameInMap("periodId")
    public String periodId;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("withAlign")
    public Boolean withAlign;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("withKr")
    public Boolean withKr;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("withProgress")
    public Boolean withProgress;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0115396701752283</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchQueryObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryObjectiveRequest self = new BatchQueryObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryObjectiveRequest setObjectiveIds(java.util.List<String> objectiveIds) {
        this.objectiveIds = objectiveIds;
        return this;
    }
    public java.util.List<String> getObjectiveIds() {
        return this.objectiveIds;
    }

    public BatchQueryObjectiveRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public BatchQueryObjectiveRequest setWithAlign(Boolean withAlign) {
        this.withAlign = withAlign;
        return this;
    }
    public Boolean getWithAlign() {
        return this.withAlign;
    }

    public BatchQueryObjectiveRequest setWithKr(Boolean withKr) {
        this.withKr = withKr;
        return this;
    }
    public Boolean getWithKr() {
        return this.withKr;
    }

    public BatchQueryObjectiveRequest setWithProgress(Boolean withProgress) {
        this.withProgress = withProgress;
        return this;
    }
    public Boolean getWithProgress() {
        return this.withProgress;
    }

    public BatchQueryObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
