// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RevertDentryVersionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RevertDentryVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RevertDentryVersionResponseBody self = new RevertDentryVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public RevertDentryVersionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
