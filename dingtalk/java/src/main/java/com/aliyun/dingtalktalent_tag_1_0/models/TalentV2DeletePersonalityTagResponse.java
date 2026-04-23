// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeletePersonalityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2DeletePersonalityTagResponseBody body;

    public static TalentV2DeletePersonalityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeletePersonalityTagResponse self = new TalentV2DeletePersonalityTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2DeletePersonalityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2DeletePersonalityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2DeletePersonalityTagResponse setBody(TalentV2DeletePersonalityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2DeletePersonalityTagResponseBody getBody() {
        return this.body;
    }

}
