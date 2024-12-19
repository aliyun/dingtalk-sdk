// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLiveInteractionPluginEffectsMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendLiveInteractionPluginEffectsMsgResponseBody body;

    public static SendLiveInteractionPluginEffectsMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendLiveInteractionPluginEffectsMsgResponse self = new SendLiveInteractionPluginEffectsMsgResponse();
        return TeaModel.build(map, self);
    }

    public SendLiveInteractionPluginEffectsMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendLiveInteractionPluginEffectsMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendLiveInteractionPluginEffectsMsgResponse setBody(SendLiveInteractionPluginEffectsMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendLiveInteractionPluginEffectsMsgResponseBody getBody() {
        return this.body;
    }

}
