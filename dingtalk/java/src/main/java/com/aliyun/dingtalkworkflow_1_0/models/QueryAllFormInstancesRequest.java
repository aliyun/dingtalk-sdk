// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllFormInstancesRequest extends TeaModel {
    // 分页游标，第一次调用传空或者null
    @NameInMap("nextToken")
    public String nextToken;

    // 翻页size
    @NameInMap("maxResults")
    public Integer maxResults;

    // 应用搭建id
    @NameInMap("appUuid")
    public String appUuid;

    // 表单模板id
    @NameInMap("formCode")
    public String formCode;

    public static QueryAllFormInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllFormInstancesRequest self = new QueryAllFormInstancesRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllFormInstancesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryAllFormInstancesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
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

}
