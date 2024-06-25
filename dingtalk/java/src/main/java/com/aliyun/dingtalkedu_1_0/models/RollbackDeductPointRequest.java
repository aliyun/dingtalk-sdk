// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RollbackDeductPointRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>biz01</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>personal</p>
     */
    @NameInMap("pointType")
    public String pointType;

    public static RollbackDeductPointRequest build(java.util.Map<String, ?> map) throws Exception {
        RollbackDeductPointRequest self = new RollbackDeductPointRequest();
        return TeaModel.build(map, self);
    }

    public RollbackDeductPointRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public RollbackDeductPointRequest setPointType(String pointType) {
        this.pointType = pointType;
        return this;
    }
    public String getPointType() {
        return this.pointType;
    }

}
