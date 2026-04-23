// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryPersonalityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2QueryPersonalityTagResponseBody body;

    public static TalentV2QueryPersonalityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryPersonalityTagResponse self = new TalentV2QueryPersonalityTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryPersonalityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2QueryPersonalityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2QueryPersonalityTagResponse setBody(TalentV2QueryPersonalityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2QueryPersonalityTagResponseBody getBody() {
        return this.body;
    }

}
