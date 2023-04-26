// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetFileUploadUrlResponseBody body;

    public static GetFileUploadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadUrlResponse self = new GetFileUploadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetFileUploadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileUploadUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFileUploadUrlResponse setBody(GetFileUploadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileUploadUrlResponseBody getBody() {
        return this.body;
    }

}
