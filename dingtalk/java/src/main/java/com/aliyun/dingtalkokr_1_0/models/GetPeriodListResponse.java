// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetPeriodListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPeriodListResponseBody body;

    public static GetPeriodListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPeriodListResponse self = new GetPeriodListResponse();
        return TeaModel.build(map, self);
    }

    public GetPeriodListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPeriodListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPeriodListResponse setBody(GetPeriodListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPeriodListResponseBody getBody() {
        return this.body;
    }

}
