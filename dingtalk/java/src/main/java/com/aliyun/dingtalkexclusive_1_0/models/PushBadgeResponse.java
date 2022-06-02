// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PushBadgeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PushBadgeResponseBody body;

    public static PushBadgeResponse build(java.util.Map<String, ?> map) throws Exception {
        PushBadgeResponse self = new PushBadgeResponse();
        return TeaModel.build(map, self);
    }

    public PushBadgeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushBadgeResponse setBody(PushBadgeResponseBody body) {
        this.body = body;
        return this;
    }
    public PushBadgeResponseBody getBody() {
        return this.body;
    }

}
