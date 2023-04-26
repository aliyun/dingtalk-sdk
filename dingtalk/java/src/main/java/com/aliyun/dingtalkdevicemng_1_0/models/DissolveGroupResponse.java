// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DissolveGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DissolveGroupResponseBody body;

    public static DissolveGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DissolveGroupResponse self = new DissolveGroupResponse();
        return TeaModel.build(map, self);
    }

    public DissolveGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DissolveGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DissolveGroupResponse setBody(DissolveGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DissolveGroupResponseBody getBody() {
        return this.body;
    }

}
