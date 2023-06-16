// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ProvidePointRequest extends TeaModel {
    @NameInMap("actionCode")
    public String actionCode;

    @NameInMap("bizId")
    public String bizId;

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
