// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocContentResponseBody body;

    public static DocContentResponse build(java.util.Map<String, ?> map) throws Exception {
        DocContentResponse self = new DocContentResponse();
        return TeaModel.build(map, self);
    }

    public DocContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocContentResponse setBody(DocContentResponseBody body) {
        this.body = body;
        return this;
    }
    public DocContentResponseBody getBody() {
        return this.body;
    }

}
