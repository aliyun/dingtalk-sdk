// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClosingAccountsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetClosingAccountsResponseBody body;

    public static GetClosingAccountsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetClosingAccountsResponse self = new GetClosingAccountsResponse();
        return TeaModel.build(map, self);
    }

    public GetClosingAccountsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetClosingAccountsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetClosingAccountsResponse setBody(GetClosingAccountsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetClosingAccountsResponseBody getBody() {
        return this.body;
    }

}
