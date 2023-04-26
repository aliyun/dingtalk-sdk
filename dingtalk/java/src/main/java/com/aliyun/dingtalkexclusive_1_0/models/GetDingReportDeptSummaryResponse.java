// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportDeptSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetDingReportDeptSummaryResponseBody body;

    public static GetDingReportDeptSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDingReportDeptSummaryResponse self = new GetDingReportDeptSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetDingReportDeptSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDingReportDeptSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDingReportDeptSummaryResponse setBody(GetDingReportDeptSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingReportDeptSummaryResponseBody getBody() {
        return this.body;
    }

}
