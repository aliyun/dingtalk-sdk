// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserAdminListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalUserAdminListResponseBody body;

    public static AgoalUserAdminListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserAdminListResponse self = new AgoalUserAdminListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalUserAdminListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalUserAdminListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalUserAdminListResponse setBody(AgoalUserAdminListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalUserAdminListResponseBody getBody() {
        return this.body;
    }

}
