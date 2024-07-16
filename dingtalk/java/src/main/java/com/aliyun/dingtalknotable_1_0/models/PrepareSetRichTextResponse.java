// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class PrepareSetRichTextResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PrepareSetRichTextResponseBody body;

    public static PrepareSetRichTextResponse build(java.util.Map<String, ?> map) throws Exception {
        PrepareSetRichTextResponse self = new PrepareSetRichTextResponse();
        return TeaModel.build(map, self);
    }

    public PrepareSetRichTextResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PrepareSetRichTextResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PrepareSetRichTextResponse setBody(PrepareSetRichTextResponseBody body) {
        this.body = body;
        return this;
    }
    public PrepareSetRichTextResponseBody getBody() {
        return this.body;
    }

}
