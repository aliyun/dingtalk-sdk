// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteTeacherRequest extends TeaModel {
    // 是否班主任；1:班主任；0:非班主任
    @NameInMap("adviser")
    public Integer adviser;

    // 钉钉企业管理员员工ID
    @NameInMap("operator")
    public String operator;

    public static DeleteTeacherRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeacherRequest self = new DeleteTeacherRequest();
        return TeaModel.build(map, self);
    }

    public DeleteTeacherRequest setAdviser(Integer adviser) {
        this.adviser = adviser;
        return this;
    }
    public Integer getAdviser() {
        return this.adviser;
    }

    public DeleteTeacherRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
