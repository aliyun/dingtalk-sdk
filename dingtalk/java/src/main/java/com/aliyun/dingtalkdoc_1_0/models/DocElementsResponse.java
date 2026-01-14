// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocElementsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocElementsResponseBody body;

    public static DocElementsResponse build(java.util.Map<String, ?> map) throws Exception {
        DocElementsResponse self = new DocElementsResponse();
        return TeaModel.build(map, self);
    }

    public DocElementsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocElementsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocElementsResponse setBody(DocElementsResponseBody body) {
        this.body = body;
        return this;
    }
    public DocElementsResponseBody getBody() {
        return this.body;
    }

}
