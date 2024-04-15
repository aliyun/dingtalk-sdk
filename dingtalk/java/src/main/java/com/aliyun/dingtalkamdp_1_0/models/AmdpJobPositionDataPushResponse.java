// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpJobPositionDataPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AmdpJobPositionDataPushResponseBody body;

    public static AmdpJobPositionDataPushResponse build(java.util.Map<String, ?> map) throws Exception {
        AmdpJobPositionDataPushResponse self = new AmdpJobPositionDataPushResponse();
        return TeaModel.build(map, self);
    }

    public AmdpJobPositionDataPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AmdpJobPositionDataPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AmdpJobPositionDataPushResponse setBody(AmdpJobPositionDataPushResponseBody body) {
        this.body = body;
        return this;
    }
    public AmdpJobPositionDataPushResponseBody getBody() {
        return this.body;
    }

}
