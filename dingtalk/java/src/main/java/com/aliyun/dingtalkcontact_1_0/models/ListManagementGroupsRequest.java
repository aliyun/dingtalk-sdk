// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListManagementGroupsRequest extends TeaModel {
    /**
     * <p>本次读取的最大数据记录数量</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>开始读取的位置</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static ListManagementGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListManagementGroupsRequest self = new ListManagementGroupsRequest();
        return TeaModel.build(map, self);
    }

    public ListManagementGroupsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListManagementGroupsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
