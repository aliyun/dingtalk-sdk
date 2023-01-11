// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCalenderSummaryResponseBody extends TeaModel {
    /**
     * <p>最近1天创建日程人数</p>
     */
    @NameInMap("calendarCreateUserCnt")
    public String calendarCreateUserCnt;

    /**
     * <p>最近1天接收日程人数</p>
     */
    @NameInMap("recvCalendarUserCnt1d")
    public String recvCalendarUserCnt1d;

    /**
     * <p>最近1天使用日程人数</p>
     */
    @NameInMap("useCalendarUserCnt1d")
    public String useCalendarUserCnt1d;

    public static GetCalenderSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCalenderSummaryResponseBody self = new GetCalenderSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCalenderSummaryResponseBody setCalendarCreateUserCnt(String calendarCreateUserCnt) {
        this.calendarCreateUserCnt = calendarCreateUserCnt;
        return this;
    }
    public String getCalendarCreateUserCnt() {
        return this.calendarCreateUserCnt;
    }

    public GetCalenderSummaryResponseBody setRecvCalendarUserCnt1d(String recvCalendarUserCnt1d) {
        this.recvCalendarUserCnt1d = recvCalendarUserCnt1d;
        return this;
    }
    public String getRecvCalendarUserCnt1d() {
        return this.recvCalendarUserCnt1d;
    }

    public GetCalenderSummaryResponseBody setUseCalendarUserCnt1d(String useCalendarUserCnt1d) {
        this.useCalendarUserCnt1d = useCalendarUserCnt1d;
        return this;
    }
    public String getUseCalendarUserCnt1d() {
        return this.useCalendarUserCnt1d;
    }

}
