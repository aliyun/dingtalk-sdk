// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class UpdateBadgeCodeUserInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateBadgeCodeUserInstanceResponseBody body;

    public static UpdateBadgeCodeUserInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateBadgeCodeUserInstanceResponse self = new UpdateBadgeCodeUserInstanceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateBadgeCodeUserInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateBadgeCodeUserInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateBadgeCodeUserInstanceResponse setBody(UpdateBadgeCodeUserInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateBadgeCodeUserInstanceResponseBody getBody() {
        return this.body;
    }

}
