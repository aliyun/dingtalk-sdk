// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteStudentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("operator")
    public String operator;

    public static DeleteStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteStudentRequest self = new DeleteStudentRequest();
        return TeaModel.build(map, self);
    }

    public DeleteStudentRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
