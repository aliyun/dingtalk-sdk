// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class SaveBadgeCodeCorpInstanceRequest extends TeaModel {
    /**
     * <p>码标识，由钉钉颁发</p>
     */
    @NameInMap("codeIdentity")
    public String codeIdentity;

    /**
     * <p>开通的企业ID</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>扩展参数</p>
     */
    @NameInMap("extInfo")
    public java.util.Map<String, String> extInfo;

    /**
     * <p>状态，OPEN或CLOSED</p>
     */
    @NameInMap("status")
    public String status;

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

    public SaveBadgeCodeCorpInstanceRequest setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

    public SaveBadgeCodeCorpInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
