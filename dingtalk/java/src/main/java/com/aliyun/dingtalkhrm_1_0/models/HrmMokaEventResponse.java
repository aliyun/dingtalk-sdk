// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmMokaEventResponseBody body;

    public static HrmMokaEventResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaEventResponse self = new HrmMokaEventResponse();
        return TeaModel.build(map, self);
    }

    public HrmMokaEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmMokaEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmMokaEventResponse setBody(HrmMokaEventResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmMokaEventResponseBody getBody() {
        return this.body;
    }

}
