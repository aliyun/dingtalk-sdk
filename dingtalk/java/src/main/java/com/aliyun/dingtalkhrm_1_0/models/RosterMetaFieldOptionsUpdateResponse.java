// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaFieldOptionsUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RosterMetaFieldOptionsUpdateResponseBody body;

    public static RosterMetaFieldOptionsUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaFieldOptionsUpdateResponse self = new RosterMetaFieldOptionsUpdateResponse();
        return TeaModel.build(map, self);
    }

    public RosterMetaFieldOptionsUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RosterMetaFieldOptionsUpdateResponse setBody(RosterMetaFieldOptionsUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public RosterMetaFieldOptionsUpdateResponseBody getBody() {
        return this.body;
    }

}
