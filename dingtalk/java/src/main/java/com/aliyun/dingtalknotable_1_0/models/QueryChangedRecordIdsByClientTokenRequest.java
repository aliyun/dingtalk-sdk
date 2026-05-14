// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryChangedRecordIdsByClientTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("clientToken")
    public String clientToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static QueryChangedRecordIdsByClientTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryChangedRecordIdsByClientTokenRequest self = new QueryChangedRecordIdsByClientTokenRequest();
        return TeaModel.build(map, self);
    }

    public QueryChangedRecordIdsByClientTokenRequest setClientToken(String clientToken) {
        this.clientToken = clientToken;
        return this;
    }
    public String getClientToken() {
        return this.clientToken;
    }

    public QueryChangedRecordIdsByClientTokenRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
