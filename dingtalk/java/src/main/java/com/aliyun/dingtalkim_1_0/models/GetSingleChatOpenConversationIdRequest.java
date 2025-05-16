// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSingleChatOpenConversationIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>022*****2134</p>
     */
    @NameInMap("userId1")
    public String userId1;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>072*****1243</p>
     */
    @NameInMap("userId2")
    public String userId2;

    public static GetSingleChatOpenConversationIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSingleChatOpenConversationIdRequest self = new GetSingleChatOpenConversationIdRequest();
        return TeaModel.build(map, self);
    }

    public GetSingleChatOpenConversationIdRequest setUserId1(String userId1) {
        this.userId1 = userId1;
        return this;
    }
    public String getUserId1() {
        return this.userId1;
    }

    public GetSingleChatOpenConversationIdRequest setUserId2(String userId2) {
        this.userId2 = userId2;
        return this;
    }
    public String getUserId2() {
        return this.userId2;
    }

}
