// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateRequest extends TeaModel {
    @NameInMap("approveId")
    public String approveId;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("punchParam")
    public ProcessApproveCreateRequestPunchParam punchParam;

    @NameInMap("subType")
    public String subType;

    @NameInMap("tagName")
    public String tagName;

    @NameInMap("userId")
    public String userId;

    public static ProcessApproveCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessApproveCreateRequest self = new ProcessApproveCreateRequest();
        return TeaModel.build(map, self);
    }

    public ProcessApproveCreateRequest setApproveId(String approveId) {
        this.approveId = approveId;
        return this;
    }
    public String getApproveId() {
        return this.approveId;
    }

    public ProcessApproveCreateRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public ProcessApproveCreateRequest setPunchParam(ProcessApproveCreateRequestPunchParam punchParam) {
        this.punchParam = punchParam;
        return this;
    }
    public ProcessApproveCreateRequestPunchParam getPunchParam() {
        return this.punchParam;
    }

    public ProcessApproveCreateRequest setSubType(String subType) {
        this.subType = subType;
        return this;
    }
    public String getSubType() {
        return this.subType;
    }

    public ProcessApproveCreateRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

    public ProcessApproveCreateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class ProcessApproveCreateRequestPunchParam extends TeaModel {
        @NameInMap("positionId")
        public String positionId;

        @NameInMap("positionName")
        public String positionName;

        @NameInMap("positionType")
        public String positionType;

        @NameInMap("punchTime")
        public Long punchTime;

        public static ProcessApproveCreateRequestPunchParam build(java.util.Map<String, ?> map) throws Exception {
            ProcessApproveCreateRequestPunchParam self = new ProcessApproveCreateRequestPunchParam();
            return TeaModel.build(map, self);
        }

        public ProcessApproveCreateRequestPunchParam setPositionId(String positionId) {
            this.positionId = positionId;
            return this;
        }
        public String getPositionId() {
            return this.positionId;
        }

        public ProcessApproveCreateRequestPunchParam setPositionName(String positionName) {
            this.positionName = positionName;
            return this;
        }
        public String getPositionName() {
            return this.positionName;
        }

        public ProcessApproveCreateRequestPunchParam setPositionType(String positionType) {
            this.positionType = positionType;
            return this;
        }
        public String getPositionType() {
            return this.positionType;
        }

        public ProcessApproveCreateRequestPunchParam setPunchTime(Long punchTime) {
            this.punchTime = punchTime;
            return this;
        }
        public Long getPunchTime() {
            return this.punchTime;
        }

    }

}
