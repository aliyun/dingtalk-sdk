// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GenerateFlashMinutesDocumentUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GenerateFlashMinutesDocumentUrlResponseBody body;

    public static GenerateFlashMinutesDocumentUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateFlashMinutesDocumentUrlResponse self = new GenerateFlashMinutesDocumentUrlResponse();
        return TeaModel.build(map, self);
    }

    public GenerateFlashMinutesDocumentUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateFlashMinutesDocumentUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GenerateFlashMinutesDocumentUrlResponse setBody(GenerateFlashMinutesDocumentUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateFlashMinutesDocumentUrlResponseBody getBody() {
        return this.body;
    }

}
