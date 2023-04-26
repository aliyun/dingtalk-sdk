// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobPostResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<CfJobPostResp> content;

    @NameInMap("requestId")
    public String requestId;

    public static GetAllJobPostResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobPostResponseBody self = new GetAllJobPostResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllJobPostResponseBody setContent(java.util.List<CfJobPostResp> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CfJobPostResp> getContent() {
        return this.content;
    }

    public GetAllJobPostResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
