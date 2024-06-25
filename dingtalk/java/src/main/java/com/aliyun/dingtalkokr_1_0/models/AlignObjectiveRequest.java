// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class AlignObjectiveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1006</p>
     */
    @NameInMap("periodId")
    public String periodId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>59YD</p>
     */
    @NameInMap("targetId")
    public String targetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0115396701752283</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AlignObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        AlignObjectiveRequest self = new AlignObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public AlignObjectiveRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

    public AlignObjectiveRequest setTargetId(String targetId) {
        this.targetId = targetId;
        return this;
    }
    public String getTargetId() {
        return this.targetId;
    }

    public AlignObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
