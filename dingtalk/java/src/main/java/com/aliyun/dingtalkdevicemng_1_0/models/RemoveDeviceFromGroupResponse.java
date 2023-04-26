// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceFromGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveDeviceFromGroupResponseBody body;

    public static RemoveDeviceFromGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceFromGroupResponse self = new RemoveDeviceFromGroupResponse();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceFromGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveDeviceFromGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveDeviceFromGroupResponse setBody(RemoveDeviceFromGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveDeviceFromGroupResponseBody getBody() {
        return this.body;
    }

}
