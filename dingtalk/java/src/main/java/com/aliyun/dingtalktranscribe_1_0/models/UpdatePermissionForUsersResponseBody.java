// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionForUsersResponseBody extends TeaModel {
    @NameInMap("isSuccess")
    public Boolean isSuccess;

    public static UpdatePermissionForUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionForUsersResponseBody self = new UpdatePermissionForUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionForUsersResponseBody setIsSuccess(Boolean isSuccess) {
        this.isSuccess = isSuccess;
        return this;
    }
    public Boolean getIsSuccess() {
        return this.isSuccess;
    }

}
