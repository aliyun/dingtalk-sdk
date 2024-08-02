// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeleteDomainWordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDomainWordsResponseBody body;

    public static DeleteDomainWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainWordsResponse self = new DeleteDomainWordsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDomainWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDomainWordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDomainWordsResponse setBody(DeleteDomainWordsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDomainWordsResponseBody getBody() {
        return this.body;
    }

}
