// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListPunchScheduleByConditionWithPagingResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<ListPunchScheduleByConditionWithPagingResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>be0d84e04316488cxxxxxxxx129522b0</p>
         */
        @NameInMap("bizOuterId")
        public String bizOuterId;

        /**
         * <strong>example:</strong>
         * <p>测试打卡机</p>
         */
        @NameInMap("positionName")
        public String positionName;

        /**
         * <strong>example:</strong>
         * <p>checkIn</p>
         */
        @NameInMap("punchSymbol")
        public String punchSymbol;

        /**
         * <strong>example:</strong>
         * <p>200003</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>1647333408000</p>
         */
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
