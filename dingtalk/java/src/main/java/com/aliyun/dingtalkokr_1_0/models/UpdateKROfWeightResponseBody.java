// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfWeightResponseBody extends TeaModel {
    @NameInMap("data")
    public UpdateKROfWeightResponseBodyData data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static UpdateKROfWeightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfWeightResponseBody self = new UpdateKROfWeightResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateKROfWeightResponseBody setData(UpdateKROfWeightResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UpdateKROfWeightResponseBodyData getData() {
        return this.data;
    }

    public UpdateKROfWeightResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateKROfWeightResponseBodyDataObjectiveProgress extends TeaModel {
        // 目标百分比。
        @NameInMap("percent")
        public Long percent;

        public static UpdateKROfWeightResponseBodyDataObjectiveProgress build(java.util.Map<String, ?> map) throws Exception {
            UpdateKROfWeightResponseBodyDataObjectiveProgress self = new UpdateKROfWeightResponseBodyDataObjectiveProgress();
            return TeaModel.build(map, self);
        }

        public UpdateKROfWeightResponseBodyDataObjectiveProgress setPercent(Long percent) {
            this.percent = percent;
            return this;
        }
        public Long getPercent() {
            return this.percent;
        }

    }

    public static class UpdateKROfWeightResponseBodyData extends TeaModel {
        @NameInMap("objectiveProgress")
        public UpdateKROfWeightResponseBodyDataObjectiveProgress objectiveProgress;

        // 目标分数。
        @NameInMap("objectiveScore")
        public Long objectiveScore;

        public static UpdateKROfWeightResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UpdateKROfWeightResponseBodyData self = new UpdateKROfWeightResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UpdateKROfWeightResponseBodyData setObjectiveProgress(UpdateKROfWeightResponseBodyDataObjectiveProgress objectiveProgress) {
            this.objectiveProgress = objectiveProgress;
            return this;
        }
        public UpdateKROfWeightResponseBodyDataObjectiveProgress getObjectiveProgress() {
            return this.objectiveProgress;
        }

        public UpdateKROfWeightResponseBodyData setObjectiveScore(Long objectiveScore) {
            this.objectiveScore = objectiveScore;
            return this;
        }
        public Long getObjectiveScore() {
            return this.objectiveScore;
        }

    }

}
