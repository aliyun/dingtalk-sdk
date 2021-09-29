// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTenantInformationResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpgradeTenantInformationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTenantInformationResponseBody self = new UpgradeTenantInformationResponseBody();
        return TeaModel.build(map, self);
    }

    public UpgradeTenantInformationResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
