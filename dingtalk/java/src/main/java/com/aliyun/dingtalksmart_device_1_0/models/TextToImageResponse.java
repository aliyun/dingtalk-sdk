// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class TextToImageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TextToImageResponseBody body;

    public static TextToImageResponse build(java.util.Map<String, ?> map) throws Exception {
        TextToImageResponse self = new TextToImageResponse();
        return TeaModel.build(map, self);
    }

    public TextToImageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TextToImageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TextToImageResponse setBody(TextToImageResponseBody body) {
        this.body = body;
        return this;
    }
    public TextToImageResponseBody getBody() {
        return this.body;
    }

}
