// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteAllResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public MuteAllResponseBody body;

    public static MuteAllResponse build(java.util.Map<String, ?> map) throws Exception {
        MuteAllResponse self = new MuteAllResponse();
        return TeaModel.build(map, self);
    }

    public MuteAllResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MuteAllResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MuteAllResponse setBody(MuteAllResponseBody body) {
        this.body = body;
        return this;
    }
    public MuteAllResponseBody getBody() {
        return this.body;
    }

}
