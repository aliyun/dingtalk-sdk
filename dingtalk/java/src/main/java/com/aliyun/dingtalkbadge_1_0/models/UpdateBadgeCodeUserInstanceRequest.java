// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class UpdateBadgeCodeUserInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<UpdateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("codeId")
    public String codeId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    @NameInMap("codeValue")
    public String codeValue;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("gmtExpired")
    public String gmtExpired;

    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtEnd")
        public String gmtEnd;

        /**
         * <p>This parameter is required.</p>
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
