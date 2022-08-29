// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetPictureDownloadUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetPictureDownloadUrlResponse setBody(GetPictureDownloadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPictureDownloadUrlResponseBody getBody() {
        return this.body;
    }

}
