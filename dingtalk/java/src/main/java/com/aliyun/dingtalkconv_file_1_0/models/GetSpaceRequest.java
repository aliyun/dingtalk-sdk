// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>open_conversation_id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
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
