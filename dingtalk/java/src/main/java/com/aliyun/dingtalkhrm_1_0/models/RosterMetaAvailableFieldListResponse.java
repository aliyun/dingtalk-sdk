// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaAvailableFieldListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RosterMetaAvailableFieldListResponseBody body;

    public static RosterMetaAvailableFieldListResponse build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaAvailableFieldListResponse self = new RosterMetaAvailableFieldListResponse();
        return TeaModel.build(map, self);
    }

    public RosterMetaAvailableFieldListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RosterMetaAvailableFieldListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RosterMetaAvailableFieldListResponse setBody(RosterMetaAvailableFieldListResponseBody body) {
        this.body = body;
        return this;
    }
    public RosterMetaAvailableFieldListResponseBody getBody() {
        return this.body;
    }

}
