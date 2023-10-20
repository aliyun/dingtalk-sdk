// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveFinishRequest extends TeaModel {
    @NameInMap("approveId")
    public String approveId;

    @NameInMap("jumpUrl")
    public String jumpUrl;

    @NameInMap("overTimeToMore")
    public Long overTimeToMore;

    @NameInMap("overtimeDuration")
    public String overtimeDuration;

    @NameInMap("subType")
    public String subType;

    @NameInMap("tagName")
    public String tagName;

    @NameInMap("topCalculateApproveDurationParam")
    public ProcessApproveFinishRequestTopCalculateApproveDurationParam topCalculateApproveDurationParam;

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
        @NameInMap("bizType")
        public Long bizType;

        @NameInMap("calculateModel")
        public Long calculateModel;

        @NameInMap("durationUnit")
        public String durationUnit;

        @NameInMap("fromTime")
        public String fromTime;

        @NameInMap("leaveCode")
        public String leaveCode;

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
