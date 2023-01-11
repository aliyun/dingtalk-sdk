// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetCoolAppAccessStatusRequest extends TeaModel {
    /**
     * <p>免登授权码</p>
     */
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>酷应用的code</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>加密的场域业务code</p>
     */
    @NameInMap("encFieldBizCode")
    public String encFieldBizCode;

    public static GetCoolAppAccessStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCoolAppAccessStatusRequest self = new GetCoolAppAccessStatusRequest();
        return TeaModel.build(map, self);
    }

    public GetCoolAppAccessStatusRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public GetCoolAppAccessStatusRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public GetCoolAppAccessStatusRequest setEncFieldBizCode(String encFieldBizCode) {
        this.encFieldBizCode = encFieldBizCode;
        return this;
    }
    public String getEncFieldBizCode() {
        return this.encFieldBizCode;
    }

}
