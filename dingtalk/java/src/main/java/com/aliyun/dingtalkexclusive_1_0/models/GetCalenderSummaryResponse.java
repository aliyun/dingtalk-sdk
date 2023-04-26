// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCalenderSummaryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCalenderSummaryResponseBody body;

    public static GetCalenderSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCalenderSummaryResponse self = new GetCalenderSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetCalenderSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCalenderSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCalenderSummaryResponse setBody(GetCalenderSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCalenderSummaryResponseBody getBody() {
        return this.body;
    }

}
