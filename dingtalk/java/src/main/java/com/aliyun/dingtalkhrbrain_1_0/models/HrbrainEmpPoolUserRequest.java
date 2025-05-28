// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainEmpPoolUserRequest extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Integer nextToken;

    @NameInMap("poolCode")
    public String poolCode;

    public static HrbrainEmpPoolUserRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainEmpPoolUserRequest self = new HrbrainEmpPoolUserRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainEmpPoolUserRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public HrbrainEmpPoolUserRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public HrbrainEmpPoolUserRequest setPoolCode(String poolCode) {
        this.poolCode = poolCode;
        return this;
    }
    public String getPoolCode() {
        return this.poolCode;
    }

}
