// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class UpdateMinutesTitleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMinutesTitleResponseBody body;

    public static UpdateMinutesTitleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMinutesTitleResponse self = new UpdateMinutesTitleResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMinutesTitleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMinutesTitleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMinutesTitleResponse setBody(UpdateMinutesTitleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMinutesTitleResponseBody getBody() {
        return this.body;
    }

}
