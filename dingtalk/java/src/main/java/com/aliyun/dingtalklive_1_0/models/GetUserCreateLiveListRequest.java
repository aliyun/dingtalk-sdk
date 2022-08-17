// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListRequest extends TeaModel {
    // 分页游标 第一次可不填， 后面填回包的值
    @NameInMap("nextToken")
    public String nextToken;

    // 单次拉去上限，默认40个
    @NameInMap("pageSize")
    public Integer pageSize;

    // post请求体, 开放平台建议以对象形式存储
    @NameInMap("statuses")
    public GetUserCreateLiveListRequestStatuses statuses;

    // 用户uid
    @NameInMap("unionId")
    public String unionId;

    public static GetUserCreateLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListRequest self = new GetUserCreateLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetUserCreateLiveListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetUserCreateLiveListRequest setStatuses(GetUserCreateLiveListRequestStatuses statuses) {
        this.statuses = statuses;
        return this;
    }
    public GetUserCreateLiveListRequestStatuses getStatuses() {
        return this.statuses;
    }

    public GetUserCreateLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetUserCreateLiveListRequestStatuses extends TeaModel {
        // 直播状态列表
        @NameInMap("statuses")
        public java.util.List<Long> statuses;

        public static GetUserCreateLiveListRequestStatuses build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListRequestStatuses self = new GetUserCreateLiveListRequestStatuses();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListRequestStatuses setStatuses(java.util.List<Long> statuses) {
            this.statuses = statuses;
            return this;
        }
        public java.util.List<Long> getStatuses() {
            return this.statuses;
        }

    }

}
