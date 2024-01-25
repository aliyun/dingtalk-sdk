// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeployFunctionCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeployFunctionCallbackResponseBody body;

    public static DeployFunctionCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        DeployFunctionCallbackResponse self = new DeployFunctionCallbackResponse();
        return TeaModel.build(map, self);
    }

    public DeployFunctionCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeployFunctionCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeployFunctionCallbackResponse setBody(DeployFunctionCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public DeployFunctionCallbackResponseBody getBody() {
        return this.body;
    }

}
