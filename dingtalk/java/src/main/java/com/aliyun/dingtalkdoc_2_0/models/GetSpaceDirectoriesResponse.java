// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetSpaceDirectoriesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSpaceDirectoriesResponseBody body;

    public static GetSpaceDirectoriesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceDirectoriesResponse self = new GetSpaceDirectoriesResponse();
        return TeaModel.build(map, self);
    }

    public GetSpaceDirectoriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpaceDirectoriesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSpaceDirectoriesResponse setBody(GetSpaceDirectoriesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceDirectoriesResponseBody getBody() {
        return this.body;
    }

}
