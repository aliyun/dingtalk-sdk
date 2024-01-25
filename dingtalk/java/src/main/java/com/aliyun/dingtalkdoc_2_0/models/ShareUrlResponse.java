// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ShareUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ShareUrlResponseBody body;

    public static ShareUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        ShareUrlResponse self = new ShareUrlResponse();
        return TeaModel.build(map, self);
    }

    public ShareUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ShareUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ShareUrlResponse setBody(ShareUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public ShareUrlResponseBody getBody() {
        return this.body;
    }

}
