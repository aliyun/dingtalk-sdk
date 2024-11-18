// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetImageTempDownloadUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetImageTempDownloadUrlResponseBody body;

    public static GetImageTempDownloadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetImageTempDownloadUrlResponse self = new GetImageTempDownloadUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetImageTempDownloadUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetImageTempDownloadUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetImageTempDownloadUrlResponse setBody(GetImageTempDownloadUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetImageTempDownloadUrlResponseBody getBody() {
        return this.body;
    }

}
