// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetSpaceDirectoriesRequest extends TeaModel {
    // 知识库节点id。
    @NameInMap("dentryId")
    public String dentryId;

    // 查询数量，最大500。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页token，第一页可不传。
    @NameInMap("nextToken")
    public String nextToken;

    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    public static GetSpaceDirectoriesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceDirectoriesRequest self = new GetSpaceDirectoriesRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceDirectoriesRequest setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public GetSpaceDirectoriesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSpaceDirectoriesRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSpaceDirectoriesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
