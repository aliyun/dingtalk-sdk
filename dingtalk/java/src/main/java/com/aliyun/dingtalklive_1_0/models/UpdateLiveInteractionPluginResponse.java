// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveInteractionPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateLiveInteractionPluginResponseBody body;

    public static UpdateLiveInteractionPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveInteractionPluginResponse self = new UpdateLiveInteractionPluginResponse();
        return TeaModel.build(map, self);
    }

    public UpdateLiveInteractionPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateLiveInteractionPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateLiveInteractionPluginResponse setBody(UpdateLiveInteractionPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateLiveInteractionPluginResponseBody getBody() {
        return this.body;
    }

}
