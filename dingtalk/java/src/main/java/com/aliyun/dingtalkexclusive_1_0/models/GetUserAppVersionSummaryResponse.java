// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAppVersionSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserAppVersionSummaryResponseBody body;

    public static GetUserAppVersionSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserAppVersionSummaryResponse self = new GetUserAppVersionSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GetUserAppVersionSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserAppVersionSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserAppVersionSummaryResponse setBody(GetUserAppVersionSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserAppVersionSummaryResponseBody getBody() {
        return this.body;
    }

}
