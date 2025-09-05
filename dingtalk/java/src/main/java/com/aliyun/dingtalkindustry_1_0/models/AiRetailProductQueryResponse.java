// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiRetailProductQueryResponseBody body;

    public static AiRetailProductQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductQueryResponse self = new AiRetailProductQueryResponse();
        return TeaModel.build(map, self);
    }

    public AiRetailProductQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiRetailProductQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiRetailProductQueryResponse setBody(AiRetailProductQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AiRetailProductQueryResponseBody getBody() {
        return this.body;
    }

}
