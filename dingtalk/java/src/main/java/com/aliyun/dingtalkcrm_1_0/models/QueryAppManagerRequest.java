// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAppManagerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>34234dfdfddd</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static QueryAppManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAppManagerRequest self = new QueryAppManagerRequest();
        return TeaModel.build(map, self);
    }

    public QueryAppManagerRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
