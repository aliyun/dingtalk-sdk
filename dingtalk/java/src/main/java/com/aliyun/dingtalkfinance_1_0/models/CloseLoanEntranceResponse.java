// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CloseLoanEntranceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CloseLoanEntranceResponseBody body;

    public static CloseLoanEntranceResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseLoanEntranceResponse self = new CloseLoanEntranceResponse();
        return TeaModel.build(map, self);
    }

    public CloseLoanEntranceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseLoanEntranceResponse setBody(CloseLoanEntranceResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseLoanEntranceResponseBody getBody() {
        return this.body;
    }

}
