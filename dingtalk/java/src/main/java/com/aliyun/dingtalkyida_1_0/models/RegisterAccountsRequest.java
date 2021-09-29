// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RegisterAccountsRequest extends TeaModel {
    // 组织id
    @NameInMap("corpId")
    public String corpId;

    // 访问秘钥
    @NameInMap("accessKey")
    public String accessKey;

    // 激活码
    @NameInMap("activeCode")
    public String activeCode;

    public static RegisterAccountsRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterAccountsRequest self = new RegisterAccountsRequest();
        return TeaModel.build(map, self);
    }

    public RegisterAccountsRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public RegisterAccountsRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public RegisterAccountsRequest setActiveCode(String activeCode) {
        this.activeCode = activeCode;
        return this;
    }
    public String getActiveCode() {
        return this.activeCode;
    }

}
