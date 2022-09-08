// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListFollowerRequest extends TeaModel {
    // 服务窗帐号ID，用于非服务窗自建应用场景下指定服务窗帐号。
    @NameInMap("accountId")
    public String accountId;

    // 分页查询页大小。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页查询下一页token,首页查询此字段可空，其它页查询时需要将此值设置炎上一次接口调用的token
    @NameInMap("nextToken")
    public String nextToken;

    public static ListFollowerRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFollowerRequest self = new ListFollowerRequest();
        return TeaModel.build(map, self);
    }

    public ListFollowerRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

    public ListFollowerRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListFollowerRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
