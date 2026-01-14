// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteConvNavTabResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static DeleteConvNavTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteConvNavTabResponseBody self = new DeleteConvNavTabResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteConvNavTabResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
