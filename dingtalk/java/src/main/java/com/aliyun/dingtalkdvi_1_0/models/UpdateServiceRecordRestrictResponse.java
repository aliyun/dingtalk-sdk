// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateServiceRecordRestrictResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateServiceRecordRestrictResponseBody body;

    public static UpdateServiceRecordRestrictResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateServiceRecordRestrictResponse self = new UpdateServiceRecordRestrictResponse();
        return TeaModel.build(map, self);
    }

    public UpdateServiceRecordRestrictResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateServiceRecordRestrictResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateServiceRecordRestrictResponse setBody(UpdateServiceRecordRestrictResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateServiceRecordRestrictResponseBody getBody() {
        return this.body;
    }

}
