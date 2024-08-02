// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetDomainWordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDomainWordsResponseBody body;

    public static GetDomainWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDomainWordsResponse self = new GetDomainWordsResponse();
        return TeaModel.build(map, self);
    }

    public GetDomainWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDomainWordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDomainWordsResponse setBody(GetDomainWordsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDomainWordsResponseBody getBody() {
        return this.body;
    }

}
