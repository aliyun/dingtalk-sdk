// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ProvidePointRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>action01</p>
     */
    @NameInMap("actionCode")
    public String actionCode;

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

    public static ProvidePointRequest build(java.util.Map<String, ?> map) throws Exception {
        ProvidePointRequest self = new ProvidePointRequest();
        return TeaModel.build(map, self);
    }

    public ProvidePointRequest setActionCode(String actionCode) {
        this.actionCode = actionCode;
        return this;
    }
    public String getActionCode() {
        return this.actionCode;
    }

    public ProvidePointRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ProvidePointRequest setPointType(String pointType) {
        this.pointType = pointType;
        return this;
    }
    public String getPointType() {
        return this.pointType;
    }

}
