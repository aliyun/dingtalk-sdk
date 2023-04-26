// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsRequest extends TeaModel {
    @NameInMap("connectorId")
    public String connectorId;

    @NameInMap("connectorProviderCorpId")
    public String connectorProviderCorpId;

    @NameInMap("integrationTypes")
    public java.util.List<String> integrationTypes;

    @NameInMap("maxResults")
    public Integer maxResults;

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
