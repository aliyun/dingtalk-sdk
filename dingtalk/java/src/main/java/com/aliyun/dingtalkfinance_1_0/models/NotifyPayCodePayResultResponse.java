// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodePayResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyPayCodePayResultResponseBody body;

    public static NotifyPayCodePayResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodePayResultResponse self = new NotifyPayCodePayResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodePayResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyPayCodePayResultResponse setBody(NotifyPayCodePayResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyPayCodePayResultResponseBody getBody() {
        return this.body;
    }

}
