// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class PagePointHistoryResponseBody extends TeaModel {
    // 是否有下一页
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一个游标值
    @NameInMap("nextToken")
    public Long nextToken;

    // 查询所得积分流水集合
    @NameInMap("pointRecordList")
    public java.util.List<PagePointHistoryResponseBodyPointRecordList> pointRecordList;

    // 总数，如果为-1则不计算总数
    @NameInMap("totalCount")
    public Long totalCount;

    public static PagePointHistoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PagePointHistoryResponseBody self = new PagePointHistoryResponseBody();
        return TeaModel.build(map, self);
    }

    public PagePointHistoryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public PagePointHistoryResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public PagePointHistoryResponseBody setPointRecordList(java.util.List<PagePointHistoryResponseBodyPointRecordList> pointRecordList) {
        this.pointRecordList = pointRecordList;
        return this;
    }
    public java.util.List<PagePointHistoryResponseBodyPointRecordList> getPointRecordList() {
        return this.pointRecordList;
    }

    public PagePointHistoryResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PagePointHistoryResponseBodyPointRecordList extends TeaModel {
        // 组织id
        @NameInMap("corpId")
        public String corpId;

        // 创建时间（精确到毫秒数）
        @NameInMap("createAt")
        public Long createAt;

        // 对应的行为代码（可空）
        @NameInMap("ruleCode")
        public String ruleCode;

        // 对应的行为名字
        @NameInMap("ruleName")
        public String ruleName;

        // 增加或减少的分数（增加为正数，减少为负数）
        @NameInMap("score")
        public Integer score;

        // 成员id
        @NameInMap("userId")
        public String userId;

        // 幂等键
        @NameInMap("uuid")
        public String uuid;

        public static PagePointHistoryResponseBodyPointRecordList build(java.util.Map<String, ?> map) throws Exception {
            PagePointHistoryResponseBodyPointRecordList self = new PagePointHistoryResponseBodyPointRecordList();
            return TeaModel.build(map, self);
        }

        public PagePointHistoryResponseBodyPointRecordList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public PagePointHistoryResponseBodyPointRecordList setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public PagePointHistoryResponseBodyPointRecordList setRuleCode(String ruleCode) {
            this.ruleCode = ruleCode;
            return this;
        }
        public String getRuleCode() {
            return this.ruleCode;
        }

        public PagePointHistoryResponseBodyPointRecordList setRuleName(String ruleName) {
            this.ruleName = ruleName;
            return this;
        }
        public String getRuleName() {
            return this.ruleName;
        }

        public PagePointHistoryResponseBodyPointRecordList setScore(Integer score) {
            this.score = score;
            return this;
        }
        public Integer getScore() {
            return this.score;
        }

        public PagePointHistoryResponseBodyPointRecordList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public PagePointHistoryResponseBodyPointRecordList setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
