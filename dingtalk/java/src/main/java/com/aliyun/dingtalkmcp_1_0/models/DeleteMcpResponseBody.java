// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class DeleteMcpResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteMcpResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMcpResponseBody self = new DeleteMcpResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMcpResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
