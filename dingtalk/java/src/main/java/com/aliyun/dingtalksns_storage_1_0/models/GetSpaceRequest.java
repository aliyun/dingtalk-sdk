// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceRequest extends TeaModel {
    /**
     * <p>会话id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceRequest self = new GetSpaceRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
