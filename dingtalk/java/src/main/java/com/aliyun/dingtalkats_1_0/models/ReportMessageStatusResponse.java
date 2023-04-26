// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ReportMessageStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReportMessageStatusResponseBody body;

    public static ReportMessageStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportMessageStatusResponse self = new ReportMessageStatusResponse();
        return TeaModel.build(map, self);
    }

    public ReportMessageStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportMessageStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReportMessageStatusResponse setBody(ReportMessageStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public ReportMessageStatusResponseBody getBody() {
        return this.body;
    }

}
