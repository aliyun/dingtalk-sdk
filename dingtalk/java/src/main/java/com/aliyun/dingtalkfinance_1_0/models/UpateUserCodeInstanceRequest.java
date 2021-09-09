// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpateUserCodeInstanceRequest extends TeaModel {
    // 用户码ID
    @NameInMap("codeId")
    public String codeId;

    // 码标识
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 码值
    @NameInMap("codeValue")
    public String codeValue;

    // 状态
    @NameInMap("status")
    public String status;

    // 企业ID
    @NameInMap("corpId")
    public String corpId;

    // 用户和企业的关系类型，区分内部员工，外部联系人，无关系普通用户
    @NameInMap("userCorpRelationType")
    public String userCorpRelationType;

    // 用户身份标识，取值和用户企业关系类型相关，如果企业无关，传入手机号
    @NameInMap("userIdentity")
    public String userIdentity;

    // 临时码，传入过期时间
    @NameInMap("gmtExpired")
    public String gmtExpired;

    // 有效时间列表，对于连续时间段，只需传入一个对象即可，注意过期时间必须晚于最晚结束时间
    @NameInMap("availableTimes")
    public java.util.List<UpateUserCodeInstanceRequestAvailableTimes> availableTimes;

    // 扩展参数
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static UpateUserCodeInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpateUserCodeInstanceRequest self = new UpateUserCodeInstanceRequest();
        return TeaModel.build(map, self);
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

    public UpateUserCodeInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public UpateUserCodeInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
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

    public UpateUserCodeInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public UpateUserCodeInstanceRequest setAvailableTimes(java.util.List<UpateUserCodeInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<UpateUserCodeInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public UpateUserCodeInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public UpateUserCodeInstanceRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public UpateUserCodeInstanceRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public static class UpateUserCodeInstanceRequestAvailableTimes extends TeaModel {
        // 开始时间
        @NameInMap("gmtStart")
        public String gmtStart;

        // 结束时间
        @NameInMap("gmtEnd")
        public String gmtEnd;

        public static UpateUserCodeInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            UpateUserCodeInstanceRequestAvailableTimes self = new UpateUserCodeInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public UpateUserCodeInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

        public UpateUserCodeInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

    }

}
