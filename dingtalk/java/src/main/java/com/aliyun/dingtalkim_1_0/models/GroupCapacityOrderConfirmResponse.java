// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderConfirmResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static GroupCapacityOrderConfirmResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderConfirmResponse self = new GroupCapacityOrderConfirmResponse();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderConfirmResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
