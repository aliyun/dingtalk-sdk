// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PushDingMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PushDingMessageResponseBody body;

    public static PushDingMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushDingMessageResponse self = new PushDingMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushDingMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushDingMessageResponse setBody(PushDingMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushDingMessageResponseBody getBody() {
        return this.body;
    }

}
