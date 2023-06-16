// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetTaskFromShanhuiDocRequest extends TeaModel {
    @NameInMap("docKey")
    public String docKey;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("unionId")
    public String unionId;

    public static GetTaskFromShanhuiDocRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskFromShanhuiDocRequest self = new GetTaskFromShanhuiDocRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskFromShanhuiDocRequest setDocKey(String docKey) {
        this.docKey = docKey;
        return this;
    }
    public String getDocKey() {
        return this.docKey;
    }

    public GetTaskFromShanhuiDocRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetTaskFromShanhuiDocRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetTaskFromShanhuiDocRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
