// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class CheckInCrowdsByMobileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckInCrowdsByMobileResponseBody body;

    public static CheckInCrowdsByMobileResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckInCrowdsByMobileResponse self = new CheckInCrowdsByMobileResponse();
        return TeaModel.build(map, self);
    }

    public CheckInCrowdsByMobileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckInCrowdsByMobileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckInCrowdsByMobileResponse setBody(CheckInCrowdsByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckInCrowdsByMobileResponseBody getBody() {
        return this.body;
    }

}
