// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ConvertLegacyEventIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConvertLegacyEventIdResponseBody body;

    public static ConvertLegacyEventIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ConvertLegacyEventIdResponse self = new ConvertLegacyEventIdResponse();
        return TeaModel.build(map, self);
    }

    public ConvertLegacyEventIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConvertLegacyEventIdResponse setBody(ConvertLegacyEventIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ConvertLegacyEventIdResponseBody getBody() {
        return this.body;
    }

}
