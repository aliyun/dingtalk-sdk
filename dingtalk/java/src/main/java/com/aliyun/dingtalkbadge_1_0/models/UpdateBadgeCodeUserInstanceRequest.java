// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class UpdateBadgeCodeUserInstanceRequest extends TeaModel {
    /**
     * <p>有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<UpdateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>用户码ID</p>
     */
    @NameInMap("codeId")
    public String codeId;

    /**
     * <p>码标识</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    /**
     * <p>码值</p>
     */
    @NameInMap("codeValue")
    public String codeValue;

    /**
     * <p>企业ID</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>扩展参数</p>
     */
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    /**
     * <p>临时码，传入过期时间</p>
     */
    @NameInMap("gmtExpired")
    public String gmtExpired;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <p>用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号</p>
     */
    @NameInMap("userIdentity")
    public String userIdentity;

    public static UpdateBadgeCodeUserInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateBadgeCodeUserInstanceRequest self = new UpdateBadgeCodeUserInstanceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateBadgeCodeUserInstanceRequest setAvailableTimes(java.util.List<UpdateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<UpdateBadgeCodeUserInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public UpdateBadgeCodeUserInstanceRequest setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

    public UpdateBadgeCodeUserInstanceRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public UpdateBadgeCodeUserInstanceRequest setCodeValue(String codeValue) {
        this.codeValue = codeValue;
        return this;
    }
    public String getCodeValue() {
        return this.codeValue;
    }

    public UpdateBadgeCodeUserInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpdateBadgeCodeUserInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public UpdateBadgeCodeUserInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public UpdateBadgeCodeUserInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpdateBadgeCodeUserInstanceRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public UpdateBadgeCodeUserInstanceRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public static class UpdateBadgeCodeUserInstanceRequestAvailableTimes extends TeaModel {
        /**
         * <p>结束时间</p>
         */
        @NameInMap("gmtEnd")
        public String gmtEnd;

        /**
         * <p>开始时间</p>
         */
        @NameInMap("gmtStart")
        public String gmtStart;

        public static UpdateBadgeCodeUserInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            UpdateBadgeCodeUserInstanceRequestAvailableTimes self = new UpdateBadgeCodeUserInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public UpdateBadgeCodeUserInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

        public UpdateBadgeCodeUserInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

    }

}
