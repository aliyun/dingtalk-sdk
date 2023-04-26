// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteGuardianRequest extends TeaModel {
    @NameInMap("operator")
    public String operator;

    @NameInMap("stuId")
    public String stuId;

    public static DeleteGuardianRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteGuardianRequest self = new DeleteGuardianRequest();
        return TeaModel.build(map, self);
    }

    public DeleteGuardianRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public DeleteGuardianRequest setStuId(String stuId) {
        this.stuId = stuId;
        return this;
    }
    public String getStuId() {
        return this.stuId;
    }

}
