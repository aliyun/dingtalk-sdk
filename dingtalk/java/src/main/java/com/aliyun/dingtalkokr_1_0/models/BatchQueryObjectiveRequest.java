// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveRequest extends TeaModel {
    @NameInMap("objectiveIds")
    public java.util.List<String> objectiveIds;

    @NameInMap("periodId")
    public String periodId;

    @NameInMap("withAlign")
    public Boolean withAlign;

    @NameInMap("withKr")
    public Boolean withKr;

    @NameInMap("withProgress")
    public Boolean withProgress;

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
