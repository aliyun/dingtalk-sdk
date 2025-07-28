// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddRetentionRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddRetentionRecordResponseBody body;

    public static AddRetentionRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRetentionRecordResponse self = new AddRetentionRecordResponse();
        return TeaModel.build(map, self);
    }

    public AddRetentionRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRetentionRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddRetentionRecordResponse setBody(AddRetentionRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRetentionRecordResponseBody getBody() {
        return this.body;
    }

}
