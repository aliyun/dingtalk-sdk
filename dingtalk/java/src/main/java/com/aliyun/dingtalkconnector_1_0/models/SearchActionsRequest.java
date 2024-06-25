// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>G-CONN-1015BC8093540B01B8D0000Q</p>
     */
    @NameInMap("connectorId")
    public String connectorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding32fff839a3e0105d</p>
     */
    @NameInMap("connectorProviderCorpId")
    public String connectorProviderCorpId;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("integrationTypes")
    public java.util.List<String> integrationTypes;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
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
