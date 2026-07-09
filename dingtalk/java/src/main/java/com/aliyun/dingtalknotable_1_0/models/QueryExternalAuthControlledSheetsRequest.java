// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryExternalAuthControlledSheetsRequest extends TeaModel {
    @NameInMap("externalAuthType")
    public String externalAuthType;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static QueryExternalAuthControlledSheetsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryExternalAuthControlledSheetsRequest self = new QueryExternalAuthControlledSheetsRequest();
        return TeaModel.build(map, self);
    }

    public QueryExternalAuthControlledSheetsRequest setExternalAuthType(String externalAuthType) {
        this.externalAuthType = externalAuthType;
        return this;
    }
    public String getExternalAuthType() {
        return this.externalAuthType;
    }

    public QueryExternalAuthControlledSheetsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryExternalAuthControlledSheetsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryExternalAuthControlledSheetsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
