// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SuperAdminApplyTemplateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SuperAdminApplyTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SuperAdminApplyTemplateResponseBody self = new SuperAdminApplyTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public SuperAdminApplyTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
