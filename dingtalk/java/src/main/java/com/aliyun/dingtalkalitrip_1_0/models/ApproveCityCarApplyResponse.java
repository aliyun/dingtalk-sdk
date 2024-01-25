// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ApproveCityCarApplyResponseBody body;

    public static ApproveCityCarApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        ApproveCityCarApplyResponse self = new ApproveCityCarApplyResponse();
        return TeaModel.build(map, self);
    }

    public ApproveCityCarApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApproveCityCarApplyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ApproveCityCarApplyResponse setBody(ApproveCityCarApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public ApproveCityCarApplyResponseBody getBody() {
        return this.body;
    }

}
