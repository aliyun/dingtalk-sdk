// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListBasicRoleInPageRequest extends TeaModel {
    // 应用的agentId
    @NameInMap("agentId")
    public String agentId;

    // 单页查询的最大条目数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询凭证，初始使用0
    @NameInMap("nextToken")
    public Long nextToken;

    public static ListBasicRoleInPageRequest build(java.util.Map<String, ?> map) throws Exception {
        ListBasicRoleInPageRequest self = new ListBasicRoleInPageRequest();
        return TeaModel.build(map, self);
    }

    public ListBasicRoleInPageRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public ListBasicRoleInPageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListBasicRoleInPageRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
