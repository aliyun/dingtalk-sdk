// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UploadAttachmentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UploadAttachmentResponseBody body;

    public static UploadAttachmentResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadAttachmentResponse self = new UploadAttachmentResponse();
        return TeaModel.build(map, self);
    }

    public UploadAttachmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadAttachmentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadAttachmentResponse setBody(UploadAttachmentResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadAttachmentResponseBody getBody() {
        return this.body;
    }

}
