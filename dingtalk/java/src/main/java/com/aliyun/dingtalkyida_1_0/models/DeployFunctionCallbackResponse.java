// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeployFunctionCallbackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeployFunctionCallbackResponse setBody(DeployFunctionCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public DeployFunctionCallbackResponseBody getBody() {
        return this.body;
    }

}
