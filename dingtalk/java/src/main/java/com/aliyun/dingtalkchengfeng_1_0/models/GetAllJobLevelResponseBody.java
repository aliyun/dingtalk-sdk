// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobLevelResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<CfJobLevelResp> content;

    @NameInMap("requestId")
    public String requestId;

    public static GetAllJobLevelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobLevelResponseBody self = new GetAllJobLevelResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllJobLevelResponseBody setContent(java.util.List<CfJobLevelResp> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CfJobLevelResp> getContent() {
        return this.content;
    }

    public GetAllJobLevelResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
