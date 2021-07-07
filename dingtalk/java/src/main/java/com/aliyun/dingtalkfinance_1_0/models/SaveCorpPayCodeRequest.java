// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class SaveCorpPayCodeRequest extends TeaModel {
    // 码标识，由钉钉颁发
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 开通的企业ID
    @NameInMap("corpId")
    public String corpId;

    // 状态，OPEN或CLOSED
    @NameInMap("status")
    public String status;

    // 扩展参数
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    // 企业orgId
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static SaveCorpPayCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveCorpPayCodeRequest self = new SaveCorpPayCodeRequest();
        return TeaModel.build(map, self);
    }

    public SaveCorpPayCodeRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public SaveCorpPayCodeRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveCorpPayCodeRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SaveCorpPayCodeRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public SaveCorpPayCodeRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SaveCorpPayCodeRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public SaveCorpPayCodeRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
