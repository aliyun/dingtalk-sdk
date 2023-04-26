// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class PullDeviceToGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PullDeviceToGroupResponseBody body;

    public static PullDeviceToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        PullDeviceToGroupResponse self = new PullDeviceToGroupResponse();
        return TeaModel.build(map, self);
    }

    public PullDeviceToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PullDeviceToGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PullDeviceToGroupResponse setBody(PullDeviceToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public PullDeviceToGroupResponseBody getBody() {
        return this.body;
    }

}
