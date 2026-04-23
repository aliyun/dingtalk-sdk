// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2AddCustomTagResponseBody body;

    public static TalentV2AddCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddCustomTagResponse self = new TalentV2AddCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2AddCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2AddCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2AddCustomTagResponse setBody(TalentV2AddCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2AddCustomTagResponseBody getBody() {
        return this.body;
    }

}
