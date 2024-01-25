// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocAppendTextResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocAppendTextResponseBody body;

    public static DocAppendTextResponse build(java.util.Map<String, ?> map) throws Exception {
        DocAppendTextResponse self = new DocAppendTextResponse();
        return TeaModel.build(map, self);
    }

    public DocAppendTextResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocAppendTextResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocAppendTextResponse setBody(DocAppendTextResponseBody body) {
        this.body = body;
        return this;
    }
    public DocAppendTextResponseBody getBody() {
        return this.body;
    }

}
