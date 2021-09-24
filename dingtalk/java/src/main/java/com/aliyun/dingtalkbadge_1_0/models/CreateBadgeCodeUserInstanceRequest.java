// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeCodeUserInstanceRequest extends TeaModel {
    // 业务幂等ID
    @NameInMap("requestId")
    public String requestId;

    // 码标识，由钉钉颁发
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 码值
    @NameInMap("codeValue")
    public String codeValue;

    // 状态，传入关闭状态需要用户手动开启后才会渲染二维
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
    public java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes;

    // 扩展参数
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static CreateBadgeCodeUserInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeCodeUserInstanceRequest self = new CreateBadgeCodeUserInstanceRequest();
        return TeaModel.build(map, self);
    }

    public CreateBadgeCodeUserInstanceRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
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

    public CreateBadgeCodeUserInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public CreateBadgeCodeUserInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
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

    public CreateBadgeCodeUserInstanceRequest setGmtExpired(String gmtExpired) {
        this.gmtExpired = gmtExpired;
        return this;
    }
    public String getGmtExpired() {
        return this.gmtExpired;
    }

    public CreateBadgeCodeUserInstanceRequest setAvailableTimes(java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> availableTimes) {
        this.availableTimes = availableTimes;
        return this;
    }
    public java.util.List<CreateBadgeCodeUserInstanceRequestAvailableTimes> getAvailableTimes() {
        return this.availableTimes;
    }

    public CreateBadgeCodeUserInstanceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public CreateBadgeCodeUserInstanceRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CreateBadgeCodeUserInstanceRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public static class CreateBadgeCodeUserInstanceRequestAvailableTimes extends TeaModel {
        // 开始时间
        @NameInMap("gmtStart")
        public String gmtStart;

        // 结束时间
        @NameInMap("gmtEnd")
        public String gmtEnd;

        public static CreateBadgeCodeUserInstanceRequestAvailableTimes build(java.util.Map<String, ?> map) throws Exception {
            CreateBadgeCodeUserInstanceRequestAvailableTimes self = new CreateBadgeCodeUserInstanceRequestAvailableTimes();
            return TeaModel.build(map, self);
        }

        public CreateBadgeCodeUserInstanceRequestAvailableTimes setGmtStart(String gmtStart) {
            this.gmtStart = gmtStart;
            return this;
        }
        public String getGmtStart() {
            return this.gmtStart;
        }

        public CreateBadgeCodeUserInstanceRequestAvailableTimes setGmtEnd(String gmtEnd) {
            this.gmtEnd = gmtEnd;
            return this;
        }
        public String getGmtEnd() {
            return this.gmtEnd;
        }

    }

}
