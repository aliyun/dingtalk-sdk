// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetDetailPageCustomTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetDetailPageCustomTabResponseBody body;

    public static SetDetailPageCustomTabResponse build(java.util.Map<String, ?> map) throws Exception {
        SetDetailPageCustomTabResponse self = new SetDetailPageCustomTabResponse();
        return TeaModel.build(map, self);
    }

    public SetDetailPageCustomTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetDetailPageCustomTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetDetailPageCustomTabResponse setBody(SetDetailPageCustomTabResponseBody body) {
        this.body = body;
        return this;
    }
    public SetDetailPageCustomTabResponseBody getBody() {
        return this.body;
    }

}
