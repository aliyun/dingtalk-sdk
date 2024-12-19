// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveInteractionPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddLiveInteractionPluginResponseBody body;

    public static AddLiveInteractionPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        AddLiveInteractionPluginResponse self = new AddLiveInteractionPluginResponse();
        return TeaModel.build(map, self);
    }

    public AddLiveInteractionPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddLiveInteractionPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddLiveInteractionPluginResponse setBody(AddLiveInteractionPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public AddLiveInteractionPluginResponseBody getBody() {
        return this.body;
    }

}
