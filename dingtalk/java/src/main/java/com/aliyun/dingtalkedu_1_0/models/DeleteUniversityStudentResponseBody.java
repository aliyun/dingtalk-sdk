// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityStudentResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteUniversityStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityStudentResponseBody self = new DeleteUniversityStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityStudentResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
