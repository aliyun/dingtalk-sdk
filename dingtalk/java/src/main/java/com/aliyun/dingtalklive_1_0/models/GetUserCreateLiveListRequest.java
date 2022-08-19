// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetUserCreateLiveListRequest extends TeaModel {
    // post请求体, 开放平台建议以对象形式存储
    @NameInMap("body")
    public GetUserCreateLiveListRequestBody body;

    // 分页游标 第一次可不填， 后面填回包的值
    @NameInMap("nextToken")
    public String nextToken;

    // 单次拉去上限，默认40个
    @NameInMap("pageSize")
    public Integer pageSize;

    // 用户uid
    @NameInMap("unionId")
    public String unionId;

    public static GetUserCreateLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserCreateLiveListRequest self = new GetUserCreateLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserCreateLiveListRequest setBody(GetUserCreateLiveListRequestBody body) {
        this.body = body;
        return this;
    }
    public GetUserCreateLiveListRequestBody getBody() {
        return this.body;
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

    public GetUserCreateLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetUserCreateLiveListRequestBody extends TeaModel {
        // 筛选直播截止时间
        @NameInMap("endTime")
        public Long endTime;

        // 筛选直播开始时间
        @NameInMap("startTime")
        public Long startTime;

        // 直播状态列表
        @NameInMap("statuses")
        public java.util.List<Long> statuses;

        // 筛选的直播标题
        @NameInMap("title")
        public String title;

        public static GetUserCreateLiveListRequestBody build(java.util.Map<String, ?> map) throws Exception {
            GetUserCreateLiveListRequestBody self = new GetUserCreateLiveListRequestBody();
            return TeaModel.build(map, self);
        }

        public GetUserCreateLiveListRequestBody setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetUserCreateLiveListRequestBody setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetUserCreateLiveListRequestBody setStatuses(java.util.List<Long> statuses) {
            this.statuses = statuses;
            return this;
        }
        public java.util.List<Long> getStatuses() {
            return this.statuses;
        }

        public GetUserCreateLiveListRequestBody setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
