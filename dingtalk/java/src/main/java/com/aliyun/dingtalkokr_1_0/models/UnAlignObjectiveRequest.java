// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UnAlignObjectiveRequest extends TeaModel {
    // 周期 ID
    @NameInMap("periodId")
    public String periodId;

    // 对齐目标的 ID
    @NameInMap("targetId")
    public String targetId;

    // 用户 ID
    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

    public static UnAlignObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        UnAlignObjectiveRequest self = new UnAlignObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public UnAlignObjectiveRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public UnAlignObjectiveRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public UnAlignObjectiveRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

}
