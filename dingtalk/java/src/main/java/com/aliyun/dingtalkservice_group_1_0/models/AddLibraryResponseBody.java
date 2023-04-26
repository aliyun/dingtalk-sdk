// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddLibraryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddLibraryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddLibraryResponseBody self = new AddLibraryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddLibraryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
