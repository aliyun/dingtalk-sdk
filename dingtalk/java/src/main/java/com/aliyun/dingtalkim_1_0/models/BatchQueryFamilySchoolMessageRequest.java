// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryFamilySchoolMessageRequest extends TeaModel {
    /**
     * <p>接收卡片的群的openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openMessageIds")
    public java.util.List<String> openMessageIds;

    /**
     * <p>用户唯一标识</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static BatchQueryFamilySchoolMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryFamilySchoolMessageRequest self = new BatchQueryFamilySchoolMessageRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryFamilySchoolMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public BatchQueryFamilySchoolMessageRequest setOpenMessageIds(java.util.List<String> openMessageIds) {
        this.openMessageIds = openMessageIds;
        return this;
    }
    public java.util.List<String> getOpenMessageIds() {
        return this.openMessageIds;
    }

    public BatchQueryFamilySchoolMessageRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
