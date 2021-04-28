// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryCollectingTraceTaskRequest extends TeaModel {
    // 员工用户ID列表
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    // isvOrgId
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // tokenGrantType
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // appKey
    @NameInMap("dingClientId")
    public String dingClientId;

    // orgId
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // oauthAppId
    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    public static QueryCollectingTraceTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectingTraceTaskRequest self = new QueryCollectingTraceTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectingTraceTaskRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public QueryCollectingTraceTaskRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public QueryCollectingTraceTaskRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public QueryCollectingTraceTaskRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public QueryCollectingTraceTaskRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public QueryCollectingTraceTaskRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

}
