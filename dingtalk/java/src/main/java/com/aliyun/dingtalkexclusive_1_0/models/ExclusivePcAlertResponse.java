// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusivePcAlertResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExclusivePcAlertResponseBody body;

    public static ExclusivePcAlertResponse build(java.util.Map<String, ?> map) throws Exception {
        ExclusivePcAlertResponse self = new ExclusivePcAlertResponse();
        return TeaModel.build(map, self);
    }

    public ExclusivePcAlertResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExclusivePcAlertResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExclusivePcAlertResponse setBody(ExclusivePcAlertResponseBody body) {
        this.body = body;
        return this;
    }
    public ExclusivePcAlertResponseBody getBody() {
        return this.body;
    }

}
