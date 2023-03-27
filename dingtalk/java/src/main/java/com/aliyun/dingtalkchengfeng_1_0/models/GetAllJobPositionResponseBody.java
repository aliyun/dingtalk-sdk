// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobPositionResponseBody extends TeaModel {
    /**
     * <p>职位列表</p>
     */
    @NameInMap("content")
    public java.util.List<CfJobPositionResp> content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static GetAllJobPositionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobPositionResponseBody self = new GetAllJobPositionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllJobPositionResponseBody setContent(java.util.List<CfJobPositionResp> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CfJobPositionResp> getContent() {
        return this.content;
    }

    public GetAllJobPositionResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
