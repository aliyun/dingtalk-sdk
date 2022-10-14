// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMultipartFileUploadInfosResponseBody body;

    public static GetMultipartFileUploadInfosResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMultipartFileUploadInfosResponse self = new GetMultipartFileUploadInfosResponse();
        return TeaModel.build(map, self);
    }

    public GetMultipartFileUploadInfosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMultipartFileUploadInfosResponse setBody(GetMultipartFileUploadInfosResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMultipartFileUploadInfosResponseBody getBody() {
        return this.body;
    }

}
