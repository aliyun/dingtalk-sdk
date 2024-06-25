// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateInterviewSignInInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1626796800000</p>
     */
    @NameInMap("signInTimeMillis")
    public Long signInTimeMillis;

    public static UpdateInterviewSignInInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInterviewSignInInfoRequest self = new UpdateInterviewSignInInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInterviewSignInInfoRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public UpdateInterviewSignInInfoRequest setSignInTimeMillis(Long signInTimeMillis) {
        this.signInTimeMillis = signInTimeMillis;
        return this;
    }
    public Long getSignInTimeMillis() {
        return this.signInTimeMillis;
    }

}
