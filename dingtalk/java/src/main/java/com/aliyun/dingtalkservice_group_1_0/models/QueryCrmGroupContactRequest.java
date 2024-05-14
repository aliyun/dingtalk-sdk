// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupContactRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("minResult")
    public Long minResult;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("searchFields")
    public String searchFields;

    public static QueryCrmGroupContactRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupContactRequest self = new QueryCrmGroupContactRequest();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupContactRequest setMinResult(Long minResult) {
        this.minResult = minResult;
        return this;
    }
    public Long getMinResult() {
        return this.minResult;
    }

    public QueryCrmGroupContactRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmGroupContactRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryCrmGroupContactRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueryCrmGroupContactRequest setSearchFields(String searchFields) {
        this.searchFields = searchFields;
        return this;
    }
    public String getSearchFields() {
        return this.searchFields;
    }

}
