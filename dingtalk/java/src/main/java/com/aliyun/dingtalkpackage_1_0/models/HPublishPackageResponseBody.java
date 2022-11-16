// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPublishPackageResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static HPublishPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HPublishPackageResponseBody self = new HPublishPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public HPublishPackageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
