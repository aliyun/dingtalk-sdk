// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUploadUrlResponseBody body;

    public static GetUploadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlResponse self = new GetUploadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetUploadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUploadUrlResponse setBody(GetUploadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUploadUrlResponseBody getBody() {
        return this.body;
    }

}
