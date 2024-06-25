// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMembersOfGroupRoleRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidXXXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>roleXXXXX</p>
     */
    @NameInMap("openRoleId")
    public String openRoleId;

    /**
     * <strong>example:</strong>
     * <p>1621502140000</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    public static QueryMembersOfGroupRoleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMembersOfGroupRoleRequest self = new QueryMembersOfGroupRoleRequest();
        return TeaModel.build(map, self);
    }

    public QueryMembersOfGroupRoleRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryMembersOfGroupRoleRequest setOpenRoleId(String openRoleId) {
        this.openRoleId = openRoleId;
        return this;
    }
    public String getOpenRoleId() {
        return this.openRoleId;
    }

    public QueryMembersOfGroupRoleRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

}
