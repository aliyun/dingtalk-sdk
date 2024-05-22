// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenInnerGroupTransferToDeptGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static OpenInnerGroupTransferToDeptGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenInnerGroupTransferToDeptGroupRequest self = new OpenInnerGroupTransferToDeptGroupRequest();
        return TeaModel.build(map, self);
    }

    public OpenInnerGroupTransferToDeptGroupRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public OpenInnerGroupTransferToDeptGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
