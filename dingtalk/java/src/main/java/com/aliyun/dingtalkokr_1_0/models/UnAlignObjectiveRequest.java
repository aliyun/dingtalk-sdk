// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UnAlignObjectiveRequest extends TeaModel {
    /**
     * <p>周期 ID</p>
     */
    @NameInMap("periodId")
    public String periodId;

    /**
     * <p>对齐目标的 ID</p>
     */
    @NameInMap("targetId")
    public String targetId;

    /**
     * <p>当前用户的 userId。</p>
     */
    @NameInMap("userId")
    public String userId;

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

    public UnAlignObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
