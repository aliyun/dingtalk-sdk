// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InitAndGetLeaveALlocationQuotasResponseBody body;

    public static InitAndGetLeaveALlocationQuotasResponse build(java.util.Map<String, ?> map) throws Exception {
        InitAndGetLeaveALlocationQuotasResponse self = new InitAndGetLeaveALlocationQuotasResponse();
        return TeaModel.build(map, self);
    }

    public InitAndGetLeaveALlocationQuotasResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitAndGetLeaveALlocationQuotasResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitAndGetLeaveALlocationQuotasResponse setBody(InitAndGetLeaveALlocationQuotasResponseBody body) {
        this.body = body;
        return this;
    }
    public InitAndGetLeaveALlocationQuotasResponseBody getBody() {
        return this.body;
    }

}
