// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SWAPP-dacdsa-example</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-daccea-example</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>100010</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static QueryAllFormInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllFormInstancesRequest self = new QueryAllFormInstancesRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllFormInstancesRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryAllFormInstancesRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public QueryAllFormInstancesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryAllFormInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
