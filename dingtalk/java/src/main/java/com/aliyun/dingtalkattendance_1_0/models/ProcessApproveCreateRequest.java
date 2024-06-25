// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessApproveCreateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>25c4c49f-cf3a-4ba1-b321-7defd93b7f89</p>
     */
    @NameInMap("approveId")
    public String approveId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user02</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("punchParam")
    public ProcessApproveCreateRequestPunchParam punchParam;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>shiftGroup</p>
     */
    @NameInMap("subType")
    public String subType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>请假</p>
     */
    @NameInMap("tagName")
    public String tagName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user01</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>longitude_latitude</p>
         */
        @NameInMap("positionId")
        public String positionId;

        /**
         * <strong>example:</strong>
         * <p>未来park</p>
         */
        @NameInMap("positionName")
        public String positionName;

        /**
         * <strong>example:</strong>
         * <p>gps</p>
         */
        @NameInMap("positionType")
        public String positionType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1650511474978</p>
         */
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
