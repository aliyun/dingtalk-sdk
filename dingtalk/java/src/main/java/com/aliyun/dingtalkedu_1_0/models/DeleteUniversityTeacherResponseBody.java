// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityTeacherResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeleteUniversityTeacherResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityTeacherResponseBody self = new DeleteUniversityTeacherResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityTeacherResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
