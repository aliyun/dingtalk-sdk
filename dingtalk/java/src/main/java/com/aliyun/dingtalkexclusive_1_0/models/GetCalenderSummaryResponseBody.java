// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCalenderSummaryResponseBody extends TeaModel {
    // 最近1天累计创建日程人数
    @NameInMap("calendarCreateUserCnt")
    public String calendarCreateUserCnt;

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

}
