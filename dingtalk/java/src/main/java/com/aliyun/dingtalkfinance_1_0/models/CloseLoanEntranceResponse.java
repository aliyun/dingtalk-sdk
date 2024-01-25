// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CloseLoanEntranceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CloseLoanEntranceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseLoanEntranceResponse setBody(CloseLoanEntranceResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseLoanEntranceResponseBody getBody() {
        return this.body;
    }

}
