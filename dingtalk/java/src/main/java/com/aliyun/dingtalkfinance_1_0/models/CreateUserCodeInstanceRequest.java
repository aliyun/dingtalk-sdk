// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateUserCodeInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<CreateUserCodeInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    @NameInMap("codeValue")
    public String codeValue;

    @NameInMap("codeValueType")
    public String codeValueType;

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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
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

    public static CreateUserCodeInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUserCodeInstanceRequest self = new CreateUserCodeInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateUserCodeInstanceRequest setAvailableTimes(java.util.List<CreateUserCodeInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<CreateUserCodeInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public CreateUserCodeInstanceRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public CreateUserCodeInstanceRequest setCodeValue(String codeValue) {
        this.codeValue = codeValue;
        return this;
    }
    public String getCodeValue() {
        return this.codeValue;
    }

    public CreateUserCodeInstanceRequest setCodeValueType(String codeValueType) {
        this.codeValueType = codeValueType;
        return this;
    }
    public String getCodeValueType() {
        return this.codeValueType;
    }

    public CreateUserCodeInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateUserCodeInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public CreateUserCodeInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public CreateUserCodeInstanceRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateUserCodeInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CreateUserCodeInstanceRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public CreateUserCodeInstanceRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public static class CreateUserCodeInstanceRequestAvailableTimes extends TeaModel {
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

        public static CreateUserCodeInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            CreateUserCodeInstanceRequestAvailableTimes self = new CreateUserCodeInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public CreateUserCodeInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

        public CreateUserCodeInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

    }

}
