// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesRequest extends TeaModel {
    /**
     * <p>应用搭建id</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>表单模板id</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>翻页size</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标，第一次调用传空或者null</p>
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
