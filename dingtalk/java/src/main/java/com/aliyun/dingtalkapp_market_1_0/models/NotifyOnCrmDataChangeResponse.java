// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class NotifyOnCrmDataChangeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public NotifyOnCrmDataChangeResponseBody body;

    public static NotifyOnCrmDataChangeResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyOnCrmDataChangeResponse self = new NotifyOnCrmDataChangeResponse();
        return TeaModel.build(map, self);
    }

    public NotifyOnCrmDataChangeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyOnCrmDataChangeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NotifyOnCrmDataChangeResponse setBody(NotifyOnCrmDataChangeResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyOnCrmDataChangeResponseBody getBody() {
        return this.body;
    }

}
