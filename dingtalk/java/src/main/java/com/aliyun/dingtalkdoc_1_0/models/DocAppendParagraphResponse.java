// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocAppendParagraphResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocAppendParagraphResponseBody body;

    public static DocAppendParagraphResponse build(java.util.Map<String, ?> map) throws Exception {
        DocAppendParagraphResponse self = new DocAppendParagraphResponse();
        return TeaModel.build(map, self);
    }

    public DocAppendParagraphResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocAppendParagraphResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocAppendParagraphResponse setBody(DocAppendParagraphResponseBody body) {
        this.body = body;
        return this;
    }
    public DocAppendParagraphResponseBody getBody() {
        return this.body;
    }

}
