// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormInstancesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2019-01-01</p>
     */
    @NameInMap("actionDate")
    public String actionDate;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    public static ListFormInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFormInstancesRequest self = new ListFormInstancesRequest();
        return TeaModel.build(map, self);
    }

    public ListFormInstancesRequest setActionDate(String actionDate) {
        this.actionDate = actionDate;
        return this;
    }
    public String getActionDate() {
        return this.actionDate;
    }

    public ListFormInstancesRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public ListFormInstancesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFormInstancesRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
