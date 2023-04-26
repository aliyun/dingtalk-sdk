// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckClosingAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CheckClosingAccountResponseBody body;

    public static CheckClosingAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckClosingAccountResponse self = new CheckClosingAccountResponse();
        return TeaModel.build(map, self);
    }

    public CheckClosingAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckClosingAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckClosingAccountResponse setBody(CheckClosingAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckClosingAccountResponseBody getBody() {
        return this.body;
    }

}
