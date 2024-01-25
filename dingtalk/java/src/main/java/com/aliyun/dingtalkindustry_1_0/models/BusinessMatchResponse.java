// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BusinessMatchResponseBody body;

    public static BusinessMatchResponse build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchResponse self = new BusinessMatchResponse();
        return TeaModel.build(map, self);
    }

    public BusinessMatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BusinessMatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BusinessMatchResponse setBody(BusinessMatchResponseBody body) {
        this.body = body;
        return this;
    }
    public BusinessMatchResponseBody getBody() {
        return this.body;
    }

}
