// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class AnalysisReportResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AnalysisReportResponseBody body;

    public static AnalysisReportResponse build(java.util.Map<String, ?> map) throws Exception {
        AnalysisReportResponse self = new AnalysisReportResponse();
        return TeaModel.build(map, self);
    }

    public AnalysisReportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnalysisReportResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnalysisReportResponse setBody(AnalysisReportResponseBody body) {
        this.body = body;
        return this;
    }
    public AnalysisReportResponseBody getBody() {
        return this.body;
    }

}
