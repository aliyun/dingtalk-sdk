// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryPersonalityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentQueryPersonalityTagResponseBody body;

    public static TalentQueryPersonalityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryPersonalityTagResponse self = new TalentQueryPersonalityTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentQueryPersonalityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentQueryPersonalityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentQueryPersonalityTagResponse setBody(TalentQueryPersonalityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentQueryPersonalityTagResponseBody getBody() {
        return this.body;
    }

}
