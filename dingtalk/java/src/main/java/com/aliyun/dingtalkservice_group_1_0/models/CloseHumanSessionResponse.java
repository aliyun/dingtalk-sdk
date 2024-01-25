// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseHumanSessionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CloseHumanSessionResponseBody body;

    public static CloseHumanSessionResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseHumanSessionResponse self = new CloseHumanSessionResponse();
        return TeaModel.build(map, self);
    }

    public CloseHumanSessionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseHumanSessionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseHumanSessionResponse setBody(CloseHumanSessionResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseHumanSessionResponseBody getBody() {
        return this.body;
    }

}
