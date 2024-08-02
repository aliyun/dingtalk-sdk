// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddDomainWordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddDomainWordsResponseBody body;

    public static AddDomainWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        AddDomainWordsResponse self = new AddDomainWordsResponse();
        return TeaModel.build(map, self);
    }

    public AddDomainWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddDomainWordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddDomainWordsResponse setBody(AddDomainWordsResponseBody body) {
        this.body = body;
        return this;
    }
    public AddDomainWordsResponseBody getBody() {
        return this.body;
    }

}
