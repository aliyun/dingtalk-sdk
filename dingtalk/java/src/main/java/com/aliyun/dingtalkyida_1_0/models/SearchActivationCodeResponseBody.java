// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchActivationCodeResponseBody extends TeaModel {
    @NameInMap("activationCode")
    public String activationCode;

    @NameInMap("authType")
    public String authType;

    @NameInMap("expireTimeGMT")
    public String expireTimeGMT;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("status")
    public Integer status;

    public static SearchActivationCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchActivationCodeResponseBody self = new SearchActivationCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchActivationCodeResponseBody setActivationCode(String activationCode) {
        this.activationCode = activationCode;
        return this;
    }
    public String getActivationCode() {
        return this.activationCode;
    }

    public SearchActivationCodeResponseBody setAuthType(String authType) {
        this.authType = authType;
        return this;
    }
    public String getAuthType() {
        return this.authType;
    }

    public SearchActivationCodeResponseBody setExpireTimeGMT(String expireTimeGMT) {
        this.expireTimeGMT = expireTimeGMT;
        return this;
    }
    public String getExpireTimeGMT() {
        return this.expireTimeGMT;
    }

    public SearchActivationCodeResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public SearchActivationCodeResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
