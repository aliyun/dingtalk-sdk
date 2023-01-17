// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class InvokeInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InvokeInstanceResponseBody body;

    public static InvokeInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        InvokeInstanceResponse self = new InvokeInstanceResponse();
        return TeaModel.build(map, self);
    }

    public InvokeInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvokeInstanceResponse setBody(InvokeInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public InvokeInstanceResponseBody getBody() {
        return this.body;
    }

}
