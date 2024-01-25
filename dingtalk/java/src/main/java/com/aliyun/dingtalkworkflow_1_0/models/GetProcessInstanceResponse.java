// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProcessInstanceResponseBody body;

    public static GetProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceResponse self = new GetProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProcessInstanceResponse setBody(GetProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
