// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddPersonalityTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2AddPersonalityTagResponseBody body;

    public static TalentV2AddPersonalityTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddPersonalityTagResponse self = new TalentV2AddPersonalityTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2AddPersonalityTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2AddPersonalityTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2AddPersonalityTagResponse setBody(TalentV2AddPersonalityTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2AddPersonalityTagResponseBody getBody() {
        return this.body;
    }

}
