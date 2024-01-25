// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryThumbnailsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDentryThumbnailsResponseBody body;

    public static GetDentryThumbnailsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDentryThumbnailsResponse self = new GetDentryThumbnailsResponse();
        return TeaModel.build(map, self);
    }

    public GetDentryThumbnailsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDentryThumbnailsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDentryThumbnailsResponse setBody(GetDentryThumbnailsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDentryThumbnailsResponseBody getBody() {
        return this.body;
    }

}
