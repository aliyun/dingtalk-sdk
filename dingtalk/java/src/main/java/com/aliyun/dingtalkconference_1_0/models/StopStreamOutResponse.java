// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopStreamOutResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public StopStreamOutResponseBody body;

    public static StopStreamOutResponse build(java.util.Map<String, ?> map) throws Exception {
        StopStreamOutResponse self = new StopStreamOutResponse();
        return TeaModel.build(map, self);
    }

    public StopStreamOutResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StopStreamOutResponse setBody(StopStreamOutResponseBody body) {
        this.body = body;
        return this;
    }
    public StopStreamOutResponseBody getBody() {
        return this.body;
    }

}
