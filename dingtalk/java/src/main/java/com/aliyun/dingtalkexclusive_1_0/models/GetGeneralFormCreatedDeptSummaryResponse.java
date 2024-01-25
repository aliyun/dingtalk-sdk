// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedDeptSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGeneralFormCreatedDeptSummaryResponseBody body;

    public static GetGeneralFormCreatedDeptSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedDeptSummaryResponse self = new GetGeneralFormCreatedDeptSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedDeptSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGeneralFormCreatedDeptSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGeneralFormCreatedDeptSummaryResponse setBody(GetGeneralFormCreatedDeptSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGeneralFormCreatedDeptSummaryResponseBody getBody() {
        return this.body;
    }

}
