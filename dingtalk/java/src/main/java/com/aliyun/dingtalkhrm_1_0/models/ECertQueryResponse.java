// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ECertQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ECertQueryResponseBody body;

    public static ECertQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        ECertQueryResponse self = new ECertQueryResponse();
        return TeaModel.build(map, self);
    }

    public ECertQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ECertQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ECertQueryResponse setBody(ECertQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public ECertQueryResponseBody getBody() {
        return this.body;
    }

}
