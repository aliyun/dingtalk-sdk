// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentMoblieResponseBody extends TeaModel {
    @NameInMap("updateResult")
    public String updateResult;

    public static CollegeUpdateStudentMoblieResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentMoblieResponseBody self = new CollegeUpdateStudentMoblieResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentMoblieResponseBody setUpdateResult(String updateResult) {
        this.updateResult = updateResult;
        return this;
    }
    public String getUpdateResult() {
        return this.updateResult;
    }

}
