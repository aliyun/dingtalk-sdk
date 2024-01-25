// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCorpRealnameUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCorpRealnameUrlResponseBody body;

    public static GetCorpRealnameUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpRealnameUrlResponse self = new GetCorpRealnameUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpRealnameUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpRealnameUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorpRealnameUrlResponse setBody(GetCorpRealnameUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpRealnameUrlResponseBody getBody() {
        return this.body;
    }

}
