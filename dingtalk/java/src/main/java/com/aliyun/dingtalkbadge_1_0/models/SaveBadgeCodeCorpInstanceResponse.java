// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class SaveBadgeCodeCorpInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveBadgeCodeCorpInstanceResponseBody body;

    public static SaveBadgeCodeCorpInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveBadgeCodeCorpInstanceResponse self = new SaveBadgeCodeCorpInstanceResponse();
        return TeaModel.build(map, self);
    }

    public SaveBadgeCodeCorpInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveBadgeCodeCorpInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveBadgeCodeCorpInstanceResponse setBody(SaveBadgeCodeCorpInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveBadgeCodeCorpInstanceResponseBody getBody() {
        return this.body;
    }

}
