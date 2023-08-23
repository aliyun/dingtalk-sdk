// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateNewGradeManagerRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static ValidateNewGradeManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateNewGradeManagerRequest self = new ValidateNewGradeManagerRequest();
        return TeaModel.build(map, self);
    }

    public ValidateNewGradeManagerRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
