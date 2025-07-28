// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class OpenQueryMinutesSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenQueryMinutesSummaryResponseBody body;

    public static OpenQueryMinutesSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenQueryMinutesSummaryResponse self = new OpenQueryMinutesSummaryResponse();
        return TeaModel.build(map, self);
    }

    public OpenQueryMinutesSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenQueryMinutesSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenQueryMinutesSummaryResponse setBody(OpenQueryMinutesSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenQueryMinutesSummaryResponseBody getBody() {
        return this.body;
    }

}
