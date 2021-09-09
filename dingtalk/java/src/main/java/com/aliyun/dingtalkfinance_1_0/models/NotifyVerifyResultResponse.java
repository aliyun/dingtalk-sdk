// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyVerifyResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public NotifyVerifyResultResponseBody body;

    public static NotifyVerifyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyVerifyResultResponse self = new NotifyVerifyResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyVerifyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyVerifyResultResponse setBody(NotifyVerifyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyVerifyResultResponseBody getBody() {
        return this.body;
    }

}
