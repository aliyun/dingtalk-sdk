// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2QueryTagLikeListResponseBody body;

    public static TalentV2QueryTagLikeListResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeListResponse self = new TalentV2QueryTagLikeListResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2QueryTagLikeListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2QueryTagLikeListResponse setBody(TalentV2QueryTagLikeListResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2QueryTagLikeListResponseBody getBody() {
        return this.body;
    }

}
