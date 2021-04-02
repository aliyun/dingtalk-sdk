// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDownloadInfoResponseBody body;

    public static GetDownloadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoResponse self = new GetDownloadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDownloadInfoResponse setBody(GetDownloadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDownloadInfoResponseBody getBody() {
        return this.body;
    }

}
