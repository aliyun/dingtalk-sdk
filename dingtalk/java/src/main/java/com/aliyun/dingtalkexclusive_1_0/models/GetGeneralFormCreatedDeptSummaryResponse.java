// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedDeptSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetGeneralFormCreatedDeptSummaryResponse setBody(GetGeneralFormCreatedDeptSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGeneralFormCreatedDeptSummaryResponseBody getBody() {
        return this.body;
    }

}
