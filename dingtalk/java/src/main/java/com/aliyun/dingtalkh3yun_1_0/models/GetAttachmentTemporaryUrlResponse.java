// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentTemporaryUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAttachmentTemporaryUrlResponseBody body;

    public static GetAttachmentTemporaryUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentTemporaryUrlResponse self = new GetAttachmentTemporaryUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetAttachmentTemporaryUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAttachmentTemporaryUrlResponse setBody(GetAttachmentTemporaryUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAttachmentTemporaryUrlResponseBody getBody() {
        return this.body;
    }

}
