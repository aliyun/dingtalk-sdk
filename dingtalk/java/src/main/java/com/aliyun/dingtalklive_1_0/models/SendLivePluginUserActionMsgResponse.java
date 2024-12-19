// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLivePluginUserActionMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendLivePluginUserActionMsgResponseBody body;

    public static SendLivePluginUserActionMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendLivePluginUserActionMsgResponse self = new SendLivePluginUserActionMsgResponse();
        return TeaModel.build(map, self);
    }

    public SendLivePluginUserActionMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendLivePluginUserActionMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendLivePluginUserActionMsgResponse setBody(SendLivePluginUserActionMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendLivePluginUserActionMsgResponseBody getBody() {
        return this.body;
    }

}
