// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluExclusiveModelResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LiandanluExclusiveModelResponseBody body;

    public static LiandanluExclusiveModelResponse build(java.util.Map<String, ?> map) throws Exception {
        LiandanluExclusiveModelResponse self = new LiandanluExclusiveModelResponse();
        return TeaModel.build(map, self);
    }

    public LiandanluExclusiveModelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LiandanluExclusiveModelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LiandanluExclusiveModelResponse setBody(LiandanluExclusiveModelResponseBody body) {
        this.body = body;
        return this;
    }
    public LiandanluExclusiveModelResponseBody getBody() {
        return this.body;
    }

}
