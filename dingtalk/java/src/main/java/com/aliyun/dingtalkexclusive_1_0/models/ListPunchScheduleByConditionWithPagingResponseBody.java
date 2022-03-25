// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPunchScheduleByConditionWithPagingResponseBody extends TeaModel {
    // 是否有更多
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 返回列表
    @NameInMap("list")
    public java.util.List<ListPunchScheduleByConditionWithPagingResponseBodyList> list;

    // 下一次游标位置
    @NameInMap("nextToken")
    public Long nextToken;

    public static ListPunchScheduleByConditionWithPagingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPunchScheduleByConditionWithPagingResponseBody self = new ListPunchScheduleByConditionWithPagingResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPunchScheduleByConditionWithPagingResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListPunchScheduleByConditionWithPagingResponseBody setList(java.util.List<ListPunchScheduleByConditionWithPagingResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListPunchScheduleByConditionWithPagingResponseBodyList> getList() {
        return this.list;
    }

    public ListPunchScheduleByConditionWithPagingResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class ListPunchScheduleByConditionWithPagingResponseBodyList extends TeaModel {
        // 巡点业务id，同个巡点id同一个用户最多会有两条记录，一条签到，一条签退
        @NameInMap("bizOuterId")
        public String bizOuterId;

        // 打卡巡点机名称
        @NameInMap("positionName")
        public String positionName;

        // 巡点类型（checkIn-签到，checkOut-签退）
        @NameInMap("punchSymbol")
        public String punchSymbol;

        // 用户id
        @NameInMap("userId")
        public String userId;

        // 用户巡点打卡时间
        @NameInMap("userPunchTime")
        public Long userPunchTime;

        public static ListPunchScheduleByConditionWithPagingResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListPunchScheduleByConditionWithPagingResponseBodyList self = new ListPunchScheduleByConditionWithPagingResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListPunchScheduleByConditionWithPagingResponseBodyList setBizOuterId(String bizOuterId) {
            this.bizOuterId = bizOuterId;
            return this;
        }
        public String getBizOuterId() {
            return this.bizOuterId;
        }

        public ListPunchScheduleByConditionWithPagingResponseBodyList setPositionName(String positionName) {
            this.positionName = positionName;
            return this;
        }
        public String getPositionName() {
            return this.positionName;
        }

        public ListPunchScheduleByConditionWithPagingResponseBodyList setPunchSymbol(String punchSymbol) {
            this.punchSymbol = punchSymbol;
            return this;
        }
        public String getPunchSymbol() {
            return this.punchSymbol;
        }

        public ListPunchScheduleByConditionWithPagingResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListPunchScheduleByConditionWithPagingResponseBodyList setUserPunchTime(Long userPunchTime) {
            this.userPunchTime = userPunchTime;
            return this;
        }
        public Long getUserPunchTime() {
            return this.userPunchTime;
        }

    }

}
