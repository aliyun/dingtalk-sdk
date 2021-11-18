// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class SaveBadgeCodeCorpInstanceRequest extends TeaModel {
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
    public java.util.Map<String, String> extInfo;

    // 组织ID
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // ISV组织ID
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    public static SaveBadgeCodeCorpInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveBadgeCodeCorpInstanceRequest self = new SaveBadgeCodeCorpInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveBadgeCodeCorpInstanceRequest setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public SaveBadgeCodeCorpInstanceRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveBadgeCodeCorpInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SaveBadgeCodeCorpInstanceRequest setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

    public SaveBadgeCodeCorpInstanceRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SaveBadgeCodeCorpInstanceRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

}
