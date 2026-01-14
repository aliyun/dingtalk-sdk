// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class ActivateMcpResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ActivateMcpResponseBody body;

    public static ActivateMcpResponse build(java.util.Map<String, ?> map) throws Exception {
        ActivateMcpResponse self = new ActivateMcpResponse();
        return TeaModel.build(map, self);
    }

    public ActivateMcpResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ActivateMcpResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ActivateMcpResponse setBody(ActivateMcpResponseBody body) {
        this.body = body;
        return this;
    }
    public ActivateMcpResponseBody getBody() {
        return this.body;
    }

}
