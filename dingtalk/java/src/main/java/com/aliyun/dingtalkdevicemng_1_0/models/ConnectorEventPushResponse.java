// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ConnectorEventPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConnectorEventPushResponseBody body;

    public static ConnectorEventPushResponse build(java.util.Map<String, ?> map) throws Exception {
        ConnectorEventPushResponse self = new ConnectorEventPushResponse();
        return TeaModel.build(map, self);
    }

    public ConnectorEventPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConnectorEventPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConnectorEventPushResponse setBody(ConnectorEventPushResponseBody body) {
        this.body = body;
        return this;
    }
    public ConnectorEventPushResponseBody getBody() {
        return this.body;
    }

}
