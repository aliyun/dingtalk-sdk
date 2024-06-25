// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class BatchBossCheckRequest extends TeaModel {
    @NameInMap("models")
    public java.util.List<BatchBossCheckRequestModels> models;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static BatchBossCheckRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchBossCheckRequest self = new BatchBossCheckRequest();
        return TeaModel.build(map, self);
    }

    public BatchBossCheckRequest setModels(java.util.List<BatchBossCheckRequestModels> models) {
        this.models = models;
        return this;
    }
    public java.util.List<BatchBossCheckRequestModels> getModels() {
        return this.models;
    }

    public BatchBossCheckRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class BatchBossCheckRequestModels extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("absentMin")
        public Long absentMin;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("planId")
        public Long planId;

        @NameInMap("remark")
        public String remark;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>Normal</p>
         */
        @NameInMap("timeResult")
        public String timeResult;

        public static BatchBossCheckRequestModels build(java.util.Map<String, ?> map) throws Exception {
            BatchBossCheckRequestModels self = new BatchBossCheckRequestModels();
            return TeaModel.build(map, self);
        }

        public BatchBossCheckRequestModels setAbsentMin(Long absentMin) {
            this.absentMin = absentMin;
            return this;
        }
        public Long getAbsentMin() {
            return this.absentMin;
        }

        public BatchBossCheckRequestModels setPlanId(Long planId) {
            this.planId = planId;
            return this;
        }
        public Long getPlanId() {
            return this.planId;
        }

        public BatchBossCheckRequestModels setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BatchBossCheckRequestModels setTimeResult(String timeResult) {
            this.timeResult = timeResult;
            return this;
        }
        public String getTimeResult() {
            return this.timeResult;
        }

    }

}
