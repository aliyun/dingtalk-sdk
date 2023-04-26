// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedDeptSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetDocCreatedDeptSummaryResponseBody body;

    public static GetDocCreatedDeptSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedDeptSummaryResponse self = new GetDocCreatedDeptSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedDeptSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDocCreatedDeptSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDocCreatedDeptSummaryResponse setBody(GetDocCreatedDeptSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDocCreatedDeptSummaryResponseBody getBody() {
        return this.body;
    }

}
