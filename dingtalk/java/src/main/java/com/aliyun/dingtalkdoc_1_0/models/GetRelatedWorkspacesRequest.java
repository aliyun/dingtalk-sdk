// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedWorkspacesRequest extends TeaModel {
    // 是否查询最近访问文档列表
    @NameInMap("includeRecent")
    public Boolean includeRecent;

    // 发起操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static GetRelatedWorkspacesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedWorkspacesRequest self = new GetRelatedWorkspacesRequest();
        return TeaModel.build(map, self);
    }

    public GetRelatedWorkspacesRequest setIncludeRecent(Boolean includeRecent) {
        this.includeRecent = includeRecent;
        return this;
    }
    public Boolean getIncludeRecent() {
        return this.includeRecent;
    }

    public GetRelatedWorkspacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
