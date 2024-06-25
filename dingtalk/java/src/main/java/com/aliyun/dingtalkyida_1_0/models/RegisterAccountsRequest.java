// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RegisterAccountsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>hexaaaa</p>
     */
    @NameInMap("accessKey")
    public String accessKey;

    /**
     * <strong>example:</strong>
     * <p>acc-1732245789</p>
     */
    @NameInMap("activeCode")
    public String activeCode;

    /**
     * <strong>example:</strong>
     * <p>ding123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static RegisterAccountsRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterAccountsRequest self = new RegisterAccountsRequest();
        return TeaModel.build(map, self);
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

    public RegisterAccountsRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
