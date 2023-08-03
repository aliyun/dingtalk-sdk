// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CrossOrgMigrateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CrossOrgMigrateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CrossOrgMigrateResponseBody self = new CrossOrgMigrateResponseBody();
        return TeaModel.build(map, self);
    }

    public CrossOrgMigrateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
