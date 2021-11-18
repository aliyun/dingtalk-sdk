// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class SaveCorpPayCodeResponseBody extends TeaModel {
    // 码标识
    @NameInMap("codeIdentity")
    public String codeIdentity;

    // 开通的企业ID
    @NameInMap("corpId")
    public String corpId;

    // 状态
    @NameInMap("status")
    public String status;

    // 扩展参数
    @NameInMap("extInfo")
    public java.util.Map<String, String> extInfo;

    public static SaveCorpPayCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveCorpPayCodeResponseBody self = new SaveCorpPayCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveCorpPayCodeResponseBody setCodeIdentity(String codeIdentity) {
        this.codeIdentity = codeIdentity;
        return this;
    }
    public String getCodeIdentity() {
        return this.codeIdentity;
    }

    public SaveCorpPayCodeResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveCorpPayCodeResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public SaveCorpPayCodeResponseBody setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

}
