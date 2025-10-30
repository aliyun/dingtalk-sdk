// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class ConnectionOmniChannelTiktokMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConnectionOmniChannelTiktokMessageResponseBody body;

    public static ConnectionOmniChannelTiktokMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        ConnectionOmniChannelTiktokMessageResponse self = new ConnectionOmniChannelTiktokMessageResponse();
        return TeaModel.build(map, self);
    }

    public ConnectionOmniChannelTiktokMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConnectionOmniChannelTiktokMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConnectionOmniChannelTiktokMessageResponse setBody(ConnectionOmniChannelTiktokMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public ConnectionOmniChannelTiktokMessageResponseBody getBody() {
        return this.body;
    }

}
