// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CorpInfoResponseBody body;

    public static CorpInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CorpInfoResponse self = new CorpInfoResponse();
        return TeaModel.build(map, self);
    }

    public CorpInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CorpInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CorpInfoResponse setBody(CorpInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CorpInfoResponseBody getBody() {
        return this.body;
    }

}
