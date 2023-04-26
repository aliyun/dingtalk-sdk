// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceLogResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReportDeviceLogResponseBody body;

    public static ReportDeviceLogResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceLogResponse self = new ReportDeviceLogResponse();
        return TeaModel.build(map, self);
    }

    public ReportDeviceLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportDeviceLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReportDeviceLogResponse setBody(ReportDeviceLogResponseBody body) {
        this.body = body;
        return this;
    }
    public ReportDeviceLogResponseBody getBody() {
        return this.body;
    }

}
