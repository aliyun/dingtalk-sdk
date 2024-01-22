// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanTextImageGetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LiandanTextImageGetResponseBody body;

    public static LiandanTextImageGetResponse build(java.util.Map<String, ?> map) throws Exception {
        LiandanTextImageGetResponse self = new LiandanTextImageGetResponse();
        return TeaModel.build(map, self);
    }

    public LiandanTextImageGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LiandanTextImageGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LiandanTextImageGetResponse setBody(LiandanTextImageGetResponseBody body) {
        this.body = body;
        return this;
    }
    public LiandanTextImageGetResponseBody getBody() {
        return this.body;
    }

}
