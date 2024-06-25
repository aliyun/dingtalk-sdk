// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListActionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>default</p>
     */
    @NameInMap("openInstanceId")
    public String openInstanceId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("productionType")
    public Long productionType;

    public static PageListActionRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListActionRequest self = new PageListActionRequest();
        return TeaModel.build(map, self);
    }

    public PageListActionRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PageListActionRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PageListActionRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public PageListActionRequest setProductionType(Long productionType) {
        this.productionType = productionType;
        return this;
    }
    public Long getProductionType() {
        return this.productionType;
    }

}
