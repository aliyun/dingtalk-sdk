// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class VoiceCloneResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public VoiceCloneResponseBody body;

    public static VoiceCloneResponse build(java.util.Map<String, ?> map) throws Exception {
        VoiceCloneResponse self = new VoiceCloneResponse();
        return TeaModel.build(map, self);
    }

    public VoiceCloneResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public VoiceCloneResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public VoiceCloneResponse setBody(VoiceCloneResponseBody body) {
        this.body = body;
        return this;
    }
    public VoiceCloneResponseBody getBody() {
        return this.body;
    }

}
