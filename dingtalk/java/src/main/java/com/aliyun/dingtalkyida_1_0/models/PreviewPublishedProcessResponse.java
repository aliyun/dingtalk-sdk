// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PreviewPublishedProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PreviewPublishedProcessResponseBody body;

    public static PreviewPublishedProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        PreviewPublishedProcessResponse self = new PreviewPublishedProcessResponse();
        return TeaModel.build(map, self);
    }

    public PreviewPublishedProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreviewPublishedProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreviewPublishedProcessResponse setBody(PreviewPublishedProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public PreviewPublishedProcessResponseBody getBody() {
        return this.body;
    }

}
