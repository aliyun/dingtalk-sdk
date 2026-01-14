// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySmartDeviceAiSummaryResponseBody body;

    public static QuerySmartDeviceAiSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSummaryResponse self = new QuerySmartDeviceAiSummaryResponse();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySmartDeviceAiSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySmartDeviceAiSummaryResponse setBody(QuerySmartDeviceAiSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySmartDeviceAiSummaryResponseBody getBody() {
        return this.body;
    }

}
