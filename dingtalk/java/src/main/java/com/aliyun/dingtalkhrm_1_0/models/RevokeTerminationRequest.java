// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RevokeTerminationRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2163515669935611</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RevokeTerminationRequest build(java.util.Map<String, ?> map) throws Exception {
        RevokeTerminationRequest self = new RevokeTerminationRequest();
        return TeaModel.build(map, self);
    }

    public RevokeTerminationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
