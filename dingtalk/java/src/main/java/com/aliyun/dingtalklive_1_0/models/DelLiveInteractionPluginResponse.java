// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DelLiveInteractionPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DelLiveInteractionPluginResponseBody body;

    public static DelLiveInteractionPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        DelLiveInteractionPluginResponse self = new DelLiveInteractionPluginResponse();
        return TeaModel.build(map, self);
    }

    public DelLiveInteractionPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DelLiveInteractionPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DelLiveInteractionPluginResponse setBody(DelLiveInteractionPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public DelLiveInteractionPluginResponseBody getBody() {
        return this.body;
    }

}
