// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CreateApproveRequest extends TeaModel {
    // 三方审批单id，全局唯一
    @NameInMap("approveId")
    public String approveId;

    // 审批人员工id
    @NameInMap("opUserid")
    public String opUserid;

    // 审批单关联的打卡信息
    @NameInMap("punchParam")
    public CreateApproveRequestPunchParam punchParam;

    // 子类型名称，最大长度20个字符
    @NameInMap("subType")
    public String subType;

    // 审批单类型名称，最大长度20个字符
    @NameInMap("tagName")
    public String tagName;

    // 员工id
    @NameInMap("userid")
    public String userid;

    public static CreateApproveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateApproveRequest self = new CreateApproveRequest();
        return TeaModel.build(map, self);
    }

    public CreateApproveRequest setApproveId(String approveId) {
        this.approveId = approveId;
        return this;
    }
    public String getApproveId() {
        return this.approveId;
    }

    public CreateApproveRequest setOpUserid(String opUserid) {
        this.opUserid = opUserid;
        return this;
    }
    public String getOpUserid() {
        return this.opUserid;
    }

    public CreateApproveRequest setPunchParam(CreateApproveRequestPunchParam punchParam) {
        this.punchParam = punchParam;
        return this;
    }
    public CreateApproveRequestPunchParam getPunchParam() {
        return this.punchParam;
    }

    public CreateApproveRequest setSubType(String subType) {
        this.subType = subType;
        return this;
    }
    public String getSubType() {
        return this.subType;
    }

    public CreateApproveRequest setTagName(String tagName) {
        this.tagName = tagName;
        return this;
    }
    public String getTagName() {
        return this.tagName;
    }

    public CreateApproveRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public static class CreateApproveRequestPunchParam extends TeaModel {
        // 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
        @NameInMap("positionId")
        public String positionId;

        // 地理位置名称
        @NameInMap("positionName")
        public String positionName;

        // 地理位置类型：wifi/ble/gps
        @NameInMap("positionType")
        public String positionType;

        // 打卡时间，单位毫秒
        @NameInMap("punchTime")
        public Long punchTime;

        public static CreateApproveRequestPunchParam build(java.util.Map<String, ?> map) throws Exception {
            CreateApproveRequestPunchParam self = new CreateApproveRequestPunchParam();
            return TeaModel.build(map, self);
        }

        public CreateApproveRequestPunchParam setPositionId(String positionId) {
            this.positionId = positionId;
            return this;
        }
        public String getPositionId() {
            return this.positionId;
        }

        public CreateApproveRequestPunchParam setPositionName(String positionName) {
            this.positionName = positionName;
            return this;
        }
        public String getPositionName() {
            return this.positionName;
        }

        public CreateApproveRequestPunchParam setPositionType(String positionType) {
            this.positionType = positionType;
            return this;
        }
        public String getPositionType() {
            return this.positionType;
        }

        public CreateApproveRequestPunchParam setPunchTime(Long punchTime) {
            this.punchTime = punchTime;
            return this;
        }
        public Long getPunchTime() {
            return this.punchTime;
        }

    }

}
