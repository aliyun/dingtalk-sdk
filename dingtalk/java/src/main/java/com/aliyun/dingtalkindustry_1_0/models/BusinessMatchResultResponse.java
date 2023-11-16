// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BusinessMatchResultResponseBody body;

    public static BusinessMatchResultResponse build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchResultResponse self = new BusinessMatchResultResponse();
        return TeaModel.build(map, self);
    }

    public BusinessMatchResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BusinessMatchResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BusinessMatchResultResponse setBody(BusinessMatchResultResponseBody body) {
        this.body = body;
        return this;
    }
    public BusinessMatchResultResponseBody getBody() {
        return this.body;
    }

}
