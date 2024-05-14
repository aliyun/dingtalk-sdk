// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListCrmPersonalCustomersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<String> body;

    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    @NameInMap("relationType")
    public String relationType;

    public static ListCrmPersonalCustomersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListCrmPersonalCustomersRequest self = new ListCrmPersonalCustomersRequest();
        return TeaModel.build(map, self);
    }

    public ListCrmPersonalCustomersRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

    public ListCrmPersonalCustomersRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

    public ListCrmPersonalCustomersRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
