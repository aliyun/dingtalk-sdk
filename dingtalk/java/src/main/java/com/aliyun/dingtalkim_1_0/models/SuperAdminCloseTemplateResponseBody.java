// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SuperAdminCloseTemplateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SuperAdminCloseTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SuperAdminCloseTemplateResponseBody self = new SuperAdminCloseTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public SuperAdminCloseTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
