// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QuerySubscribeStatusRequest extends TeaModel {
    // post请求体, 开放平台建议以对象形式存储
    @NameInMap("body")
    public QuerySubscribeStatusRequestBody body;

    // 用户id（主播id）
    @NameInMap("unionId")
    public String unionId;

    public static QuerySubscribeStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySubscribeStatusRequest self = new QuerySubscribeStatusRequest();
        return TeaModel.build(map, self);
    }

    public QuerySubscribeStatusRequest setBody(QuerySubscribeStatusRequestBody body) {
        this.body = body;
        return this;
    }
    public QuerySubscribeStatusRequestBody getBody() {
        return this.body;
    }

    public QuerySubscribeStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class QuerySubscribeStatusRequestBody extends TeaModel {
        // 直播id列表
        @NameInMap("liveIds")
        public java.util.List<String> liveIds;

        public static QuerySubscribeStatusRequestBody build(java.util.Map<String, ?> map) throws Exception {
            QuerySubscribeStatusRequestBody self = new QuerySubscribeStatusRequestBody();
            return TeaModel.build(map, self);
        }

        public QuerySubscribeStatusRequestBody setLiveIds(java.util.List<String> liveIds) {
            this.liveIds = liveIds;
            return this;
        }
        public java.util.List<String> getLiveIds() {
            return this.liveIds;
        }

    }

}
