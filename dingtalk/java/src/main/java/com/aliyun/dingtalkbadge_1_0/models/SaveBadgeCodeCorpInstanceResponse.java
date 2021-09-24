// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class SaveBadgeCodeCorpInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SaveBadgeCodeCorpInstanceResponse setBody(SaveBadgeCodeCorpInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveBadgeCodeCorpInstanceResponseBody getBody() {
        return this.body;
    }

}
