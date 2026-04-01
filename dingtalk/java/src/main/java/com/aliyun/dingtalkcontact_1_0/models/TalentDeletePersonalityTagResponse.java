// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeletePersonalityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentDeletePersonalityTagResponseBody body;

    public static TalentDeletePersonalityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentDeletePersonalityTagResponse self = new TalentDeletePersonalityTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentDeletePersonalityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentDeletePersonalityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentDeletePersonalityTagResponse setBody(TalentDeletePersonalityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentDeletePersonalityTagResponseBody getBody() {
        return this.body;
    }

}
