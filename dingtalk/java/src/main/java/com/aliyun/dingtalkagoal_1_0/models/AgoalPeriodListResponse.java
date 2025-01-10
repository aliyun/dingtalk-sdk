// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPeriodListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalPeriodListResponseBody body;

    public static AgoalPeriodListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalPeriodListResponse self = new AgoalPeriodListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalPeriodListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalPeriodListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalPeriodListResponse setBody(AgoalPeriodListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalPeriodListResponseBody getBody() {
        return this.body;
    }

}
