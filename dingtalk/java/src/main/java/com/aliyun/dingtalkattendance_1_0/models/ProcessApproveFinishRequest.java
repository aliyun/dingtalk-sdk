// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveFinishRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1234abcd</p>
     */
    @NameInMap("approveId")
    public String approveId;

    /**
     * <strong>example:</strong>
     * <p><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></p>
     */
    @NameInMap("jumpUrl")
    public String jumpUrl;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("overTimeToMore")
    public Long overTimeToMore;

    /**
     * <strong>example:</strong>
     * <p>1.07</p>
     */
    @NameInMap("overtimeDuration")
    public String overtimeDuration;

    /**
     * <strong>example:</strong>
     * <p>年假</p>
     */
    @NameInMap("subType")
    public String subType;

    /**
     * <strong>example:</strong>
     * <p>请假</p>
     */
    @NameInMap("tagName")
    public String tagName;

    @NameInMap("topCalculateApproveDurationParam")
    public ProcessApproveFinishRequestTopCalculateApproveDurationParam topCalculateApproveDurationParam;

    /**
     * <strong>example:</strong>
     * <p>manager123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ProcessApproveFinishRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveFinishRequest self = new ProcessApproveFinishRequest();
        return TeaModel.build(map, self);
    }

    public ProcessApproveFinishRequest setApproveId(String approveId) {
        this.approveId = approveId;
        return this;
    }
    public String getApproveId() {
        return this.approveId;
    }

    public ProcessApproveFinishRequest setJumpUrl(String jumpUrl) {
        this.jumpUrl = jumpUrl;
        return this;
    }
    public String getJumpUrl() {
        return this.jumpUrl;
    }

    public ProcessApproveFinishRequest setOverTimeToMore(Long overTimeToMore) {
        this.overTimeToMore = overTimeToMore;
        return this;
    }
    public Long getOverTimeToMore() {
        return this.overTimeToMore;
    }

    public ProcessApproveFinishRequest setOvertimeDuration(String overtimeDuration) {
        this.overtimeDuration = overtimeDuration;
        return this;
    }
    public String getOvertimeDuration() {
        return this.overtimeDuration;
    }

    public ProcessApproveFinishRequest setSubType(String subType) {
        this.subType = subType;
        return this;
    }
    public String getSubType() {
        return this.subType;
    }

    public ProcessApproveFinishRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

    public ProcessApproveFinishRequest setTopCalculateApproveDurationParam(ProcessApproveFinishRequestTopCalculateApproveDurationParam topCalculateApproveDurationParam) {
        this.topCalculateApproveDurationParam = topCalculateApproveDurationParam;
        return this;
    }
    public ProcessApproveFinishRequestTopCalculateApproveDurationParam getTopCalculateApproveDurationParam() {
        return this.topCalculateApproveDurationParam;
    }

    public ProcessApproveFinishRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class ProcessApproveFinishRequestTopCalculateApproveDurationParam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("bizType")
        public Long bizType;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("calculateModel")
        public Long calculateModel;

        /**
         * <strong>example:</strong>
         * <p>day</p>
         */
        @NameInMap("durationUnit")
        public String durationUnit;

        /**
         * <strong>example:</strong>
         * <p>2019-08-15</p>
         */
        @NameInMap("fromTime")
        public String fromTime;

        /**
         * <strong>example:</strong>
         * <p>3afdsf-143dsadw3-ad23</p>
         */
        @NameInMap("leaveCode")
        public String leaveCode;

        /**
         * <strong>example:</strong>
         * <p>2019-08-15</p>
         */
        @NameInMap("toTime")
        public String toTime;

        public static ProcessApproveFinishRequestTopCalculateApproveDurationParam build(java.util.Map<String, ?> map) throws Exception {
            ProcessApproveFinishRequestTopCalculateApproveDurationParam self = new ProcessApproveFinishRequestTopCalculateApproveDurationParam();
            return TeaModel.build(map, self);
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setBizType(Long bizType) {
            this.bizType = bizType;
            return this;
        }
        public Long getBizType() {
            return this.bizType;
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setCalculateModel(Long calculateModel) {
            this.calculateModel = calculateModel;
            return this;
        }
        public Long getCalculateModel() {
            return this.calculateModel;
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setDurationUnit(String durationUnit) {
            this.durationUnit = durationUnit;
            return this;
        }
        public String getDurationUnit() {
            return this.durationUnit;
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setFromTime(String fromTime) {
            this.fromTime = fromTime;
            return this;
        }
        public String getFromTime() {
            return this.fromTime;
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public ProcessApproveFinishRequestTopCalculateApproveDurationParam setToTime(String toTime) {
            this.toTime = toTime;
            return this;
        }
        public String getToTime() {
            return this.toTime;
        }

    }

}
