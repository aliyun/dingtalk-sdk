// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityTeacherResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CreateUniversityTeacherResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityTeacherResponseBody self = new CreateUniversityTeacherResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateUniversityTeacherResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
