// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryAppPropertiesResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteDentryAppPropertiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryAppPropertiesResponseBody self = new DeleteDentryAppPropertiesResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDentryAppPropertiesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
