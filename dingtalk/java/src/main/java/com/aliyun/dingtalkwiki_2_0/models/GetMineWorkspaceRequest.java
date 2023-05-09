// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetMineWorkspaceRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static GetMineWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMineWorkspaceRequest self = new GetMineWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public GetMineWorkspaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
