// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateUserCodeInstanceRequest extends TeaModel {
    /**
     * <p>有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间</p>
     */
    @NameInMap("availableTimes")
    public java.util.List<CreateUserCodeInstanceRequestAvailableTimes> availableTimes;

    /**
     * <p>码标识，由钉钉颁发</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    /**
     * <p>码值</p>
     */
    @NameInMap("codeValue")
    public String codeValue;

    /**
     * <p>码值类型，钉钉静态码值：DING_STATIC，访客码或会展码传入</p>
     */
    @NameInMap("codeValueType")
    public String codeValueType;

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
     * <p>业务幂等ID</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>状态，传入关闭状态需要用户手动开启后才会渲染二维</p>
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
         * <p>结束时间</p>
         */
        @NameInMap("gmtEnd")
        public String gmtEnd;

        /**
         * <p>开始时间</p>
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
