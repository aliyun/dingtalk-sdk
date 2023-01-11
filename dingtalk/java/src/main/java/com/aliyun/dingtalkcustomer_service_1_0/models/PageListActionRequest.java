// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListActionRequest extends TeaModel {
    /**
     * <p>本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>用来标记当前开始读取的位置，置空表示从头开始。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>实例id</p>
     */
    @NameInMap("openInstanceId")
    public String openInstanceId;

    /**
     * <p>产品类型</p>
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
