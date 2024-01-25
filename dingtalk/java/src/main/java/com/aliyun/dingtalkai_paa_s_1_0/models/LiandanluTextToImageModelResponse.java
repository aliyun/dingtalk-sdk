// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluTextToImageModelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LiandanluTextToImageModelResponseBody body;

    public static LiandanluTextToImageModelResponse build(java.util.Map<String, ?> map) throws Exception {
        LiandanluTextToImageModelResponse self = new LiandanluTextToImageModelResponse();
        return TeaModel.build(map, self);
    }

    public LiandanluTextToImageModelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LiandanluTextToImageModelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LiandanluTextToImageModelResponse setBody(LiandanluTextToImageModelResponseBody body) {
        this.body = body;
        return this;
    }
    public LiandanluTextToImageModelResponseBody getBody() {
        return this.body;
    }

}
