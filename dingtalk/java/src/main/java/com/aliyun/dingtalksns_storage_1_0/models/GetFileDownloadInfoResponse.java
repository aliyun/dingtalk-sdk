// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFileDownloadInfoResponseBody body;

    public static GetFileDownloadInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoResponse self = new GetFileDownloadInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileDownloadInfoResponse setBody(GetFileDownloadInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileDownloadInfoResponseBody getBody() {
        return this.body;
    }

}
