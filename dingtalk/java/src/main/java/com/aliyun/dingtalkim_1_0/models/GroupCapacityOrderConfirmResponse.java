// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderConfirmResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupCapacityOrderConfirmResponseBody body;

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

    public GroupCapacityOrderConfirmResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupCapacityOrderConfirmResponse setBody(GroupCapacityOrderConfirmResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupCapacityOrderConfirmResponseBody getBody() {
        return this.body;
    }

}
