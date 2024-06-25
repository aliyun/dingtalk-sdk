// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardSpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager01</p>
     */
    @NameInMap("operationUserId")
    public String operationUserId;

    public static QueryBlackboardSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardSpaceRequest self = new QueryBlackboardSpaceRequest();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardSpaceRequest setOperationUserId(String operationUserId) {
        this.operationUserId = operationUserId;
        return this;
    }
    public String getOperationUserId() {
        return this.operationUserId;
    }

}
