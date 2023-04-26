// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetProcessConfigResponseBody body;

    public static GetProcessConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessConfigResponse self = new GetProcessConfigResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessConfigResponse setBody(GetProcessConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessConfigResponseBody getBody() {
        return this.body;
    }

}
