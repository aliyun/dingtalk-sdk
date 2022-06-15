// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public InitAndGetLeaveALlocationQuotasResponse setBody(InitAndGetLeaveALlocationQuotasResponseBody body) {
        this.body = body;
        return this;
    }
    public InitAndGetLeaveALlocationQuotasResponseBody getBody() {
        return this.body;
    }

}
