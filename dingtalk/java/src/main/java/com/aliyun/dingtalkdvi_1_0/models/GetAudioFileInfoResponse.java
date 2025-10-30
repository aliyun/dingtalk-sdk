// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAudioFileInfoResponseBody body;

    public static GetAudioFileInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileInfoResponse self = new GetAudioFileInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAudioFileInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAudioFileInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAudioFileInfoResponse setBody(GetAudioFileInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAudioFileInfoResponseBody getBody() {
        return this.body;
    }

}
