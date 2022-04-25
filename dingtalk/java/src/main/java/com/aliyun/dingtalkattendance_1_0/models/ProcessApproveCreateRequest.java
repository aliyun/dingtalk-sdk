// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateRequest extends TeaModel {
    // 三方审批单id，全局唯一
    @NameInMap("approveId")
    public String approveId;

    // 审批人员工userId
    @NameInMap("opUserId")
    public String opUserId;

    // 审批单关联的打卡信息
    @NameInMap("punchParam")
    public ProcessApproveCreateRequestPunchParam punchParam;

    // 审批单子类型名称：调店:shiftGroup
    @NameInMap("subType")
    public String subType;

    // 审批单类型名称
    @NameInMap("tagName")
    public String tagName;

    // 员工的userId
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
        // 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
        @NameInMap("positionId")
        public String positionId;

        // 地理位置名称
        @NameInMap("positionName")
        public String positionName;

        // 地理位置类型：wifi/ble/gps
        @NameInMap("positionType")
        public String positionType;

        // 审批单关联的打卡时间，单位毫秒
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
