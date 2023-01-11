// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeptRequest extends TeaModel {
    /**
     * <p>钉钉企业管理员员工ID</p>
     */
    @NameInMap("operator")
    public String operator;

    public static DeleteDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeptRequest self = new DeleteDeptRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDeptRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
