// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class PublishTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PublishTemplateResponseBody body;

    public static PublishTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishTemplateResponse self = new PublishTemplateResponse();
        return TeaModel.build(map, self);
    }

    public PublishTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PublishTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PublishTemplateResponse setBody(PublishTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishTemplateResponseBody getBody() {
        return this.body;
    }

}
