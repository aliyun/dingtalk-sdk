// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmPersonalCustomerRequest extends TeaModel {
    // 操作人用户ID
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    public static DeleteCrmPersonalCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmPersonalCustomerRequest self = new DeleteCrmPersonalCustomerRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCrmPersonalCustomerRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

}
