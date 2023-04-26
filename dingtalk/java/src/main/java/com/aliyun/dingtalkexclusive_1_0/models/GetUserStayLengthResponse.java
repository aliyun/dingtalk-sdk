// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserStayLengthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserStayLengthResponseBody body;

    public static GetUserStayLengthResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserStayLengthResponse self = new GetUserStayLengthResponse();
        return TeaModel.build(map, self);
    }

    public GetUserStayLengthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserStayLengthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserStayLengthResponse setBody(GetUserStayLengthResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserStayLengthResponseBody getBody() {
        return this.body;
    }

}
