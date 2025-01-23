// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUploadVideoPlayInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUploadVideoPlayInfoResponseBody body;

    public static QueryUploadVideoPlayInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUploadVideoPlayInfoResponse self = new QueryUploadVideoPlayInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryUploadVideoPlayInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUploadVideoPlayInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUploadVideoPlayInfoResponse setBody(QueryUploadVideoPlayInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUploadVideoPlayInfoResponseBody getBody() {
        return this.body;
    }

}
