// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCardVisitorStatisticDataResponseBody extends TeaModel {
    /**
     * <p>发送名片数</p>
     */
    @NameInMap("cardSendCnt")
    public Long cardSendCnt;

    /**
     * <p>今日访客增加数</p>
     */
    @NameInMap("todayVisitAddCnt")
    public Long todayVisitAddCnt;

    /**
     * <p>今日访客数</p>
     */
    @NameInMap("todayVisitCnt")
    public Long todayVisitCnt;

    /**
     * <p>总访客新增数</p>
     */
    @NameInMap("totalVisitAddCnt")
    public Long totalVisitAddCnt;

    /**
     * <p>总访客数</p>
     */
    @NameInMap("totalVisitCnt")
    public Long totalVisitCnt;

    /**
     * <p>微信今日访客新增数</p>
     */
    @NameInMap("wechatTodayVisitAddCnt")
    public Long wechatTodayVisitAddCnt;

    /**
     * <p>微信今日访客数</p>
     */
    @NameInMap("wechatTodayVisitCnt")
    public Long wechatTodayVisitCnt;

    /**
     * <p>微信今日访客增加数</p>
     */
    @NameInMap("wechatTotalVisitAddCnt")
    public Long wechatTotalVisitAddCnt;

    /**
     * <p>微信访客数</p>
     */
    @NameInMap("wechatTotalVisitCnt")
    public Long wechatTotalVisitCnt;

    public static QueryCardVisitorStatisticDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCardVisitorStatisticDataResponseBody self = new QueryCardVisitorStatisticDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCardVisitorStatisticDataResponseBody setCardSendCnt(Long cardSendCnt) {
        this.cardSendCnt = cardSendCnt;
        return this;
    }
    public Long getCardSendCnt() {
        return this.cardSendCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setTodayVisitAddCnt(Long todayVisitAddCnt) {
        this.todayVisitAddCnt = todayVisitAddCnt;
        return this;
    }
    public Long getTodayVisitAddCnt() {
        return this.todayVisitAddCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setTodayVisitCnt(Long todayVisitCnt) {
        this.todayVisitCnt = todayVisitCnt;
        return this;
    }
    public Long getTodayVisitCnt() {
        return this.todayVisitCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setTotalVisitAddCnt(Long totalVisitAddCnt) {
        this.totalVisitAddCnt = totalVisitAddCnt;
        return this;
    }
    public Long getTotalVisitAddCnt() {
        return this.totalVisitAddCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setTotalVisitCnt(Long totalVisitCnt) {
        this.totalVisitCnt = totalVisitCnt;
        return this;
    }
    public Long getTotalVisitCnt() {
        return this.totalVisitCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setWechatTodayVisitAddCnt(Long wechatTodayVisitAddCnt) {
        this.wechatTodayVisitAddCnt = wechatTodayVisitAddCnt;
        return this;
    }
    public Long getWechatTodayVisitAddCnt() {
        return this.wechatTodayVisitAddCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setWechatTodayVisitCnt(Long wechatTodayVisitCnt) {
        this.wechatTodayVisitCnt = wechatTodayVisitCnt;
        return this;
    }
    public Long getWechatTodayVisitCnt() {
        return this.wechatTodayVisitCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setWechatTotalVisitAddCnt(Long wechatTotalVisitAddCnt) {
        this.wechatTotalVisitAddCnt = wechatTotalVisitAddCnt;
        return this;
    }
    public Long getWechatTotalVisitAddCnt() {
        return this.wechatTotalVisitAddCnt;
    }

    public QueryCardVisitorStatisticDataResponseBody setWechatTotalVisitCnt(Long wechatTotalVisitCnt) {
        this.wechatTotalVisitCnt = wechatTotalVisitCnt;
        return this;
    }
    public Long getWechatTotalVisitCnt() {
        return this.wechatTotalVisitCnt;
    }

}
