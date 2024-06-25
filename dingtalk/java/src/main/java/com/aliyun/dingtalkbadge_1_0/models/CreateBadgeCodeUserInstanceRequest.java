// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeCodeUserInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>TEST</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    @NameInMap("codeValue")
    public String codeValue;

    /**
     * <strong>example:</strong>
     * <p>DING_STATIC</p>
     */
    @NameInMap("codeValueType")
    public String codeValueType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpid1234</p>
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
     * 
     * <strong>example:</strong>
     * <p>yyyy-MM-dd HH:mm:ss</p>
     */
    @NameInMap("gmtExpired")
    public String gmtExpired;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202102021212</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OPEN</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>INTERNAL_STAFF</p>
     */
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>86-xxxxxx</p>
     */
    @NameInMap("userIdentity")
    public String userIdentity;

    public static CreateBadgeCodeUserInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeCodeUserInstanceRequest self = new CreateBadgeCodeUserInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateBadgeCodeUserInstanceRequest setAvailableTimes(java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public CreateBadgeCodeUserInstanceRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public CreateBadgeCodeUserInstanceRequest setCodeValue(String codeValue) {
        this.codeValue = codeValue;
        return this;
    }
    public String getCodeValue() {
        return this.codeValue;
    }

    public CreateBadgeCodeUserInstanceRequest setCodeValueType(String codeValueType) {
        this.codeValueType = codeValueType;
        return this;
    }
    public String getCodeValueType() {
        return this.codeValueType;
    }

    public CreateBadgeCodeUserInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateBadgeCodeUserInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public CreateBadgeCodeUserInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public CreateBadgeCodeUserInstanceRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateBadgeCodeUserInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CreateBadgeCodeUserInstanceRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public CreateBadgeCodeUserInstanceRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public static class CreateBadgeCodeUserInstanceRequestAvailableTimes extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>yyyy-MM-dd HH:mm:ss</p>
         */
        @NameInMap("gmtEnd")
        public String gmtEnd;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>yyyy-MM-dd HH:mm:ss</p>
         */
        @NameInMap("gmtStart")
        public String gmtStart;

        public static CreateBadgeCodeUserInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            CreateBadgeCodeUserInstanceRequestAvailableTimes self = new CreateBadgeCodeUserInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public CreateBadgeCodeUserInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

        public CreateBadgeCodeUserInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

    }

}
