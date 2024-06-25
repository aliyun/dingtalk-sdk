// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfScoreResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public UpdateKROfScoreResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>50</p>
         */
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
