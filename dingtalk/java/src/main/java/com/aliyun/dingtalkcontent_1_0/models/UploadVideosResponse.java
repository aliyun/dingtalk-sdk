// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class UploadVideosResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UploadVideosResponseBody body;

    public static UploadVideosResponse build(java.util.Map<String, ?> map) throws Exception {
        UploadVideosResponse self = new UploadVideosResponse();
        return TeaModel.build(map, self);
    }

    public UploadVideosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UploadVideosResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UploadVideosResponse setBody(UploadVideosResponseBody body) {
        this.body = body;
        return this;
    }
    public UploadVideosResponseBody getBody() {
        return this.body;
    }

}
