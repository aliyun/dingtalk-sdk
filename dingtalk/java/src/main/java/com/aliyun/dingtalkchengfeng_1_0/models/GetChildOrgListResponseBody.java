// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetChildOrgListResponseBody extends TeaModel {
    /**
     * <p>返回内容</p>
     */
    @NameInMap("content")
    public java.util.List<CfOrgResp> content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static GetChildOrgListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetChildOrgListResponseBody self = new GetChildOrgListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetChildOrgListResponseBody setContent(java.util.List<CfOrgResp> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CfOrgResp> getContent() {
        return this.content;
    }

    public GetChildOrgListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
