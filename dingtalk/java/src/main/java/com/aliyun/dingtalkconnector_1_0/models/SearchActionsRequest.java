// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsRequest extends TeaModel {
    /**
     * <p>连接器的ID</p>
     */
    @NameInMap("connectorId")
    public String connectorId;

    /**
     * <p>连接器提供组织ID</p>
     */
    @NameInMap("connectorProviderCorpId")
    public String connectorProviderCorpId;

    /**
     * <p>集成类型，默认只有basic-基础类型</p>
     */
    @NameInMap("integrationTypes")
    public java.util.List<String> integrationTypes;

    /**
     * <p>最大返回记录数</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>查询位置，为空表示从头开始</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static SearchActionsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchActionsRequest self = new SearchActionsRequest();
        return TeaModel.build(map, self);
    }

    public SearchActionsRequest setConnectorId(String connectorId) {
        this.connectorId = connectorId;
        return this;
    }
    public String getConnectorId() {
        return this.connectorId;
    }

    public SearchActionsRequest setConnectorProviderCorpId(String connectorProviderCorpId) {
        this.connectorProviderCorpId = connectorProviderCorpId;
        return this;
    }
    public String getConnectorProviderCorpId() {
        return this.connectorProviderCorpId;
    }

    public SearchActionsRequest setIntegrationTypes(java.util.List<String> integrationTypes) {
        this.integrationTypes = integrationTypes;
        return this;
    }
    public java.util.List<String> getIntegrationTypes() {
        return this.integrationTypes;
    }

    public SearchActionsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchActionsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
