// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormSchemasByCreatorRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("bizType")
    public Integer bizType;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
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
    public Long nextToken;

    public static ListFormSchemasByCreatorRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFormSchemasByCreatorRequest self = new ListFormSchemasByCreatorRequest();
        return TeaModel.build(map, self);
    }

    public ListFormSchemasByCreatorRequest setBizType(Integer bizType) {
        this.bizType = bizType;
        return this;
    }
    public Integer getBizType() {
        return this.bizType;
    }

    public ListFormSchemasByCreatorRequest setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public ListFormSchemasByCreatorRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFormSchemasByCreatorRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
