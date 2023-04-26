// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class SaveCorpPayCodeRequest extends TeaModel {
    @NameInMap("codeIdentity")
    public String codeIdentity;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extInfo")
    public java.util.Map<String, String> extInfo;

    @NameInMap("status")
    public String status;

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

    public SaveCorpPayCodeRequest setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

    public SaveCorpPayCodeRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
