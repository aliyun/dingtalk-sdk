// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2DeleteCustomTagResponseBody body;

    public static TalentV2DeleteCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteCustomTagResponse self = new TalentV2DeleteCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2DeleteCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2DeleteCustomTagResponse setBody(TalentV2DeleteCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2DeleteCustomTagResponseBody getBody() {
        return this.body;
    }

}
