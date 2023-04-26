// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetDingReportSummaryResponseBody body;

    public static GetDingReportSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDingReportSummaryResponse self = new GetDingReportSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetDingReportSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDingReportSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDingReportSummaryResponse setBody(GetDingReportSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingReportSummaryResponseBody getBody() {
        return this.body;
    }

}
