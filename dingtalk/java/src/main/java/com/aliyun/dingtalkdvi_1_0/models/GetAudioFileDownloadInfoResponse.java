// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileDownloadInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAudioFileDownloadInfoResponseBody body;

    public static GetAudioFileDownloadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileDownloadInfoResponse self = new GetAudioFileDownloadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAudioFileDownloadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAudioFileDownloadInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAudioFileDownloadInfoResponse setBody(GetAudioFileDownloadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAudioFileDownloadInfoResponseBody getBody() {
        return this.body;
    }

}
