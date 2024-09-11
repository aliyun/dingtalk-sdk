// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserSubAdminListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalUserSubAdminListResponseBody body;

    public static AgoalUserSubAdminListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserSubAdminListResponse self = new AgoalUserSubAdminListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalUserSubAdminListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalUserSubAdminListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalUserSubAdminListResponse setBody(AgoalUserSubAdminListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalUserSubAdminListResponseBody getBody() {
        return this.body;
    }

}
