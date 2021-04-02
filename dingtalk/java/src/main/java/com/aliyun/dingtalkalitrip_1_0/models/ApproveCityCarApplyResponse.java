// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ApproveCityCarApplyResponse setBody(ApproveCityCarApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public ApproveCityCarApplyResponseBody getBody() {
        return this.body;
    }

}
