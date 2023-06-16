// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class DelCallConfigRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("isvToken")
    public String isvToken;

    @NameInMap("phoneNumber")
    public String phoneNumber;

    public static DelCallConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        DelCallConfigRequest self = new DelCallConfigRequest();
        return TeaModel.build(map, self);
    }

    public DelCallConfigRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public DelCallConfigRequest setIsvToken(String isvToken) {
        this.isvToken = isvToken;
        return this;
    }
    public String getIsvToken() {
        return this.isvToken;
    }

    public DelCallConfigRequest setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
        return this;
    }
    public String getPhoneNumber() {
        return this.phoneNumber;
    }

}
