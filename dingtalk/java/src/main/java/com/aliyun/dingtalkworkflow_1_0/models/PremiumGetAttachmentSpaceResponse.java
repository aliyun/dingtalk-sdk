// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetAttachmentSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetAttachmentSpaceResponseBody body;

    public static PremiumGetAttachmentSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetAttachmentSpaceResponse self = new PremiumGetAttachmentSpaceResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetAttachmentSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetAttachmentSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetAttachmentSpaceResponse setBody(PremiumGetAttachmentSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetAttachmentSpaceResponseBody getBody() {
        return this.body;
    }

}
