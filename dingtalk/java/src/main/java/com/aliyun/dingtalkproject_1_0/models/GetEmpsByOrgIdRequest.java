// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetEmpsByOrgIdRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("needDept")
    public Boolean needDept;

    @NameInMap("nextToken")
    public Long nextToken;

    public static GetEmpsByOrgIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEmpsByOrgIdRequest self = new GetEmpsByOrgIdRequest();
        return TeaModel.build(map, self);
    }

    public GetEmpsByOrgIdRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetEmpsByOrgIdRequest setNeedDept(Boolean needDept) {
        this.needDept = needDept;
        return this;
    }
    public Boolean getNeedDept() {
        return this.needDept;
    }

    public GetEmpsByOrgIdRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
