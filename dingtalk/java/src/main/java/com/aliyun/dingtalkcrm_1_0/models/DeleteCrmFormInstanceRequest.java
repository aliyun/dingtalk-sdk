// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmFormInstanceRequest extends TeaModel {
    // 当前操作人id
    @NameInMap("currentOperatorUserId")
    public String currentOperatorUserId;

    // 模版名称
    @NameInMap("name")
    public String name;

    public static DeleteCrmFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmFormInstanceRequest self = new DeleteCrmFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCrmFormInstanceRequest setCurrentOperatorUserId(String currentOperatorUserId) {
        this.currentOperatorUserId = currentOperatorUserId;
        return this;
    }
    public String getCurrentOperatorUserId() {
        return this.currentOperatorUserId;
    }

    public DeleteCrmFormInstanceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
