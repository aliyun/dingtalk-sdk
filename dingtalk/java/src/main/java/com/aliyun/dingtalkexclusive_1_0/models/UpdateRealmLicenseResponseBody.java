// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateRealmLicenseResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateRealmLicenseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRealmLicenseResponseBody self = new UpdateRealmLicenseResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRealmLicenseResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
