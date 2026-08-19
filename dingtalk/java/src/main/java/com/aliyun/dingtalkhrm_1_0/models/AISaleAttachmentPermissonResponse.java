// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleAttachmentPermissonResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleAttachmentPermissonResponseBody body;

    public static AISaleAttachmentPermissonResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleAttachmentPermissonResponse self = new AISaleAttachmentPermissonResponse();
        return TeaModel.build(map, self);
    }

    public AISaleAttachmentPermissonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleAttachmentPermissonResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleAttachmentPermissonResponse setBody(AISaleAttachmentPermissonResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleAttachmentPermissonResponseBody getBody() {
        return this.body;
    }

}
