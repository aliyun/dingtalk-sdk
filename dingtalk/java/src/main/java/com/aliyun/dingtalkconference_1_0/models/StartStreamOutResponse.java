// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartStreamOutResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public StartStreamOutResponseBody body;

    public static StartStreamOutResponse build(java.util.Map<String, ?> map) throws Exception {
        StartStreamOutResponse self = new StartStreamOutResponse();
        return TeaModel.build(map, self);
    }

    public StartStreamOutResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StartStreamOutResponse setBody(StartStreamOutResponseBody body) {
        this.body = body;
        return this;
    }
    public StartStreamOutResponseBody getBody() {
        return this.body;
    }

}
