// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoByPackageIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFileDownloadInfoByPackageIdResponseBody body;

    public static GetFileDownloadInfoByPackageIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoByPackageIdResponse self = new GetFileDownloadInfoByPackageIdResponse();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoByPackageIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileDownloadInfoByPackageIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFileDownloadInfoByPackageIdResponse setBody(GetFileDownloadInfoByPackageIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileDownloadInfoByPackageIdResponseBody getBody() {
        return this.body;
    }

}
