// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserMetricDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserMetricDataResponseBody body;

    public static GetUserMetricDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserMetricDataResponse self = new GetUserMetricDataResponse();
        return TeaModel.build(map, self);
    }

    public GetUserMetricDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserMetricDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserMetricDataResponse setBody(GetUserMetricDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserMetricDataResponseBody getBody() {
        return this.body;
    }

}
