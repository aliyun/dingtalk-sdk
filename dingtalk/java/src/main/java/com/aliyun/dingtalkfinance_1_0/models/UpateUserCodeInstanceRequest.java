// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpateUserCodeInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<UpateUserCodeInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ccodexxxxx</p>
     */
    @NameInMap("codeId")
    public String codeId;

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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpIdxxxx</p>
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

    public static UpateUserCodeInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpateUserCodeInstanceRequest self = new UpateUserCodeInstanceRequest();
        return TeaModel.build(map, self);
    }

    public UpateUserCodeInstanceRequest setAvailableTimes(java.util.List<UpateUserCodeInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<UpateUserCodeInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public UpateUserCodeInstanceRequest setCodeId(String codeId) {
        this.codeId = codeId;
        return this;
    }
    public String getCodeId() {
        return this.codeId;
    }

    public UpateUserCodeInstanceRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public UpateUserCodeInstanceRequest setCodeValue(String codeValue) {
        this.codeValue = codeValue;
        return this;
    }
    public String getCodeValue() {
        return this.codeValue;
    }

    public UpateUserCodeInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UpateUserCodeInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public UpateUserCodeInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public UpateUserCodeInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpateUserCodeInstanceRequest setUserCorpRelationType(String userCorpRelationType) {
        this.userCorpRelationType = userCorpRelationType;
        return this;
    }
    public String getUserCorpRelationType() {
        return this.userCorpRelationType;
    }

    public UpateUserCodeInstanceRequest setUserIdentity(String userIdentity) {
        this.userIdentity = userIdentity;
        return this;
    }
    public String getUserIdentity() {
        return this.userIdentity;
    }

    public static class UpateUserCodeInstanceRequestAvailableTimes extends TeaModel {
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

        public static UpateUserCodeInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            UpateUserCodeInstanceRequestAvailableTimes self = new UpateUserCodeInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public UpateUserCodeInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

        public UpateUserCodeInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

    }

}
