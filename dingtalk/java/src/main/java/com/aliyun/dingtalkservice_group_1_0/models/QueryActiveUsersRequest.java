// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUsersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxxxx==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>KxisoOk</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>5</p>
     */
    @NameInMap("topN")
    public Long topN;

    public static QueryActiveUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUsersRequest self = new QueryActiveUsersRequest();
        return TeaModel.build(map, self);
    }

    public QueryActiveUsersRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryActiveUsersRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryActiveUsersRequest setTopN(Long topN) {
        this.topN = topN;
        return this;
    }
    public Long getTopN() {
        return this.topN;
    }

}
