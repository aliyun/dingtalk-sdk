// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreResponseBody extends TeaModel {
    @NameInMap("data")
    public UpdateKROfScoreResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static UpdateKROfScoreResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfScoreResponseBody self = new UpdateKROfScoreResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateKROfScoreResponseBody setData(UpdateKROfScoreResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UpdateKROfScoreResponseBodyData getData() {
        return this.data;
    }

    public UpdateKROfScoreResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateKROfScoreResponseBodyData extends TeaModel {
        @NameInMap("objectiveScore")
        public Long objectiveScore;

        public static UpdateKROfScoreResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UpdateKROfScoreResponseBodyData self = new UpdateKROfScoreResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UpdateKROfScoreResponseBodyData setObjectiveScore(Long objectiveScore) {
            this.objectiveScore = objectiveScore;
            return this;
        }
        public Long getObjectiveScore() {
            return this.objectiveScore;
        }

    }

}
