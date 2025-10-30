// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class GetBlackboardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ca80xxxx0a04</p>
     */
    @NameInMap("blackboardId")
    public String blackboardId;

    /**
     * <strong>example:</strong>
     * <p>manager01</p>
     */
    @NameInMap("operationUserId")
    public String operationUserId;

    public static GetBlackboardRequest build(java.util.Map<String, ?> map) throws Exception {
        GetBlackboardRequest self = new GetBlackboardRequest();
        return TeaModel.build(map, self);
    }

    public GetBlackboardRequest setBlackboardId(String blackboardId) {
        this.blackboardId = blackboardId;
        return this;
    }
    public String getBlackboardId() {
        return this.blackboardId;
    }

    public GetBlackboardRequest setOperationUserId(String operationUserId) {
        this.operationUserId = operationUserId;
        return this;
    }
    public String getOperationUserId() {
        return this.operationUserId;
    }

}
