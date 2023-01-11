// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetFamilySchoolConversationsRequest extends TeaModel {
    /**
     * <p>获取家校群数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>时间的毫秒值，分页游标</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>用户身份ID</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetFamilySchoolConversationsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFamilySchoolConversationsRequest self = new GetFamilySchoolConversationsRequest();
        return TeaModel.build(map, self);
    }

    public GetFamilySchoolConversationsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetFamilySchoolConversationsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetFamilySchoolConversationsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
