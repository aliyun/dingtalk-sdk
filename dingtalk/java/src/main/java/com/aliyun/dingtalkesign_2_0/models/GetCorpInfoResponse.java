// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetCorpInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCorpInfoResponseBody body;

    public static GetCorpInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpInfoResponse self = new GetCorpInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorpInfoResponse setBody(GetCorpInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpInfoResponseBody getBody() {
        return this.body;
    }

}
