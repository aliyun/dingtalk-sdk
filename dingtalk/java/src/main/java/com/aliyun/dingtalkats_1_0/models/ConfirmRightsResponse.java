// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ConfirmRightsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConfirmRightsResponseBody body;

    public static ConfirmRightsResponse build(java.util.Map<String, ?> map) throws Exception {
        ConfirmRightsResponse self = new ConfirmRightsResponse();
        return TeaModel.build(map, self);
    }

    public ConfirmRightsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConfirmRightsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConfirmRightsResponse setBody(ConfirmRightsResponseBody body) {
        this.body = body;
        return this;
    }
    public ConfirmRightsResponseBody getBody() {
        return this.body;
    }

}
