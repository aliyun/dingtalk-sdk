// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ClearEvaluatePerformanceCountRequest extends TeaModel {
    @NameInMap("studentIdList")
    public java.util.List<String> studentIdList;

    public static ClearEvaluatePerformanceCountRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearEvaluatePerformanceCountRequest self = new ClearEvaluatePerformanceCountRequest();
        return TeaModel.build(map, self);
    }

    public ClearEvaluatePerformanceCountRequest setStudentIdList(java.util.List<String> studentIdList) {
        this.studentIdList = studentIdList;
        return this;
    }
    public java.util.List<String> getStudentIdList() {
        return this.studentIdList;
    }

}
