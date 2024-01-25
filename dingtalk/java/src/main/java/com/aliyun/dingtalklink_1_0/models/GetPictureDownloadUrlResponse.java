// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetPictureDownloadUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPictureDownloadUrlResponseBody body;

    public static GetPictureDownloadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPictureDownloadUrlResponse self = new GetPictureDownloadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetPictureDownloadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPictureDownloadUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPictureDownloadUrlResponse setBody(GetPictureDownloadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPictureDownloadUrlResponseBody getBody() {
        return this.body;
    }

}
