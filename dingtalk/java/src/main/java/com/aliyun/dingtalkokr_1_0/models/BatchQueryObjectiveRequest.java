// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveRequest extends TeaModel {
    @NameInMap("objectiveIds")
    public java.util.List<java.io.InputStream> objectiveIds;

    // periodId
    @NameInMap("periodId")
    public java.io.InputStream periodId;

    // withAlign
    @NameInMap("withAlign")
    public Boolean withAlign;

    // withKr
    @NameInMap("withKr")
    public Boolean withKr;

    // withProgress
    @NameInMap("withProgress")
    public Boolean withProgress;

    // ownerId
    @NameInMap("ownerId")
    public String ownerId;

    public static BatchQueryObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryObjectiveRequest self = new BatchQueryObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryObjectiveRequest setObjectiveIds(java.util.List<java.io.InputStream> objectiveIds) {
        this.objectiveIds = objectiveIds;
        return this;
    }
    public java.util.List<java.io.InputStream> getObjectiveIds() {
        return this.objectiveIds;
    }

    public BatchQueryObjectiveRequest setPeriodId(java.io.InputStream periodId) {
        this.periodId = periodId;
        return this;
    }
    public java.io.InputStream getPeriodId() {
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

    public BatchQueryObjectiveRequest setOwnerId(String ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public String getOwnerId() {
        return this.ownerId;
    }

}
