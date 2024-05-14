// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteWorkspaceDocRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteWorkspaceDocRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkspaceDocRequest self = new DeleteWorkspaceDocRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWorkspaceDocRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
