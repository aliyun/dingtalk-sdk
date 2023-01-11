// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdateDentryAppPropertiesResponseBody extends TeaModel {
    /**
     * <p>本次操作是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UpdateDentryAppPropertiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateDentryAppPropertiesResponseBody self = new UpdateDentryAppPropertiesResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateDentryAppPropertiesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
