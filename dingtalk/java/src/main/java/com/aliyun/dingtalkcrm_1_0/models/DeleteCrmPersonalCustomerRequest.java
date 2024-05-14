// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmPersonalCustomerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    @NameInMap("relationType")
    public String relationType;

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

    public DeleteCrmPersonalCustomerRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
