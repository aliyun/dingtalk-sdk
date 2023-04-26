// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListObjectiveByUserResponseBody body;

    public static ListObjectiveByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByUserResponse self = new ListObjectiveByUserResponse();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListObjectiveByUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListObjectiveByUserResponse setBody(ListObjectiveByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public ListObjectiveByUserResponseBody getBody() {
        return this.body;
    }

}
