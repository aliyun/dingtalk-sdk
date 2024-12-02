// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class ListAllTaskViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAllTaskViewResponseBody body;

    public static ListAllTaskViewResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAllTaskViewResponse self = new ListAllTaskViewResponse();
        return TeaModel.build(map, self);
    }

    public ListAllTaskViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAllTaskViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAllTaskViewResponse setBody(ListAllTaskViewResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAllTaskViewResponseBody getBody() {
        return this.body;
    }

}
