// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoGetFileStatusResponseBody extends TeaModel {
    @NameInMap("status")
    public Integer status;

    @NameInMap("statusDesc")
    public String statusDesc;

    public static ChatMemoGetFileStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoGetFileStatusResponseBody self = new ChatMemoGetFileStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoGetFileStatusResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public ChatMemoGetFileStatusResponseBody setStatusDesc(String statusDesc) {
        this.statusDesc = statusDesc;
        return this;
    }
    public String getStatusDesc() {
        return this.statusDesc;
    }

}
