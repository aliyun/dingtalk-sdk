// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteEvaluatePerformanceRequest extends TeaModel {
    @NameInMap("evaluationIdList")
    public java.util.List<String> evaluationIdList;

    public static DeleteEvaluatePerformanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteEvaluatePerformanceRequest self = new DeleteEvaluatePerformanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteEvaluatePerformanceRequest setEvaluationIdList(java.util.List<String> evaluationIdList) {
        this.evaluationIdList = evaluationIdList;
        return this;
    }
    public java.util.List<String> getEvaluationIdList() {
        return this.evaluationIdList;
    }

}
