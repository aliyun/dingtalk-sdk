// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetGeneralFormCreatedSummaryResponseBody body;

    public static GetGeneralFormCreatedSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedSummaryResponse self = new GetGeneralFormCreatedSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGeneralFormCreatedSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGeneralFormCreatedSummaryResponse setBody(GetGeneralFormCreatedSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGeneralFormCreatedSummaryResponseBody getBody() {
        return this.body;
    }

}
