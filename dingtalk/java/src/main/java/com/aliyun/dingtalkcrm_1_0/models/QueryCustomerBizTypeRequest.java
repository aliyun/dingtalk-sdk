// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerBizTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static QueryCustomerBizTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerBizTypeRequest self = new QueryCustomerBizTypeRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomerBizTypeRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
