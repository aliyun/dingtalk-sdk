// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodeRefundResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyPayCodeRefundResultResponseBody body;

    public static NotifyPayCodeRefundResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodeRefundResultResponse self = new NotifyPayCodeRefundResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodeRefundResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyPayCodeRefundResultResponse setBody(NotifyPayCodeRefundResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyPayCodeRefundResultResponseBody getBody() {
        return this.body;
    }

}
