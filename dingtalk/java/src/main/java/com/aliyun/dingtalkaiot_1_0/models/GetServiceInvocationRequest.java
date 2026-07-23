// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetServiceInvocationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("invocationId")
    public String invocationId;

    public static GetServiceInvocationRequest build(java.util.Map<String, ?> map) throws Exception {
        GetServiceInvocationRequest self = new GetServiceInvocationRequest();
        return TeaModel.build(map, self);
    }

    public GetServiceInvocationRequest setInvocationId(String invocationId) {
        this.invocationId = invocationId;
        return this;
    }
    public String getInvocationId() {
        return this.invocationId;
    }

}
