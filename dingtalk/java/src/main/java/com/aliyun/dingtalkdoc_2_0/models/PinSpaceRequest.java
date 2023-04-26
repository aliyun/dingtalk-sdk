// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class PinSpaceRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static PinSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        PinSpaceRequest self = new PinSpaceRequest();
        return TeaModel.build(map, self);
    }

    public PinSpaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
