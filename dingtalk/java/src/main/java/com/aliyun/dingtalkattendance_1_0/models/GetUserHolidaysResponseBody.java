// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysResponseBody extends TeaModel {
    // 员工假期列表
    @NameInMap("result")
    public java.util.List<GetUserHolidaysResponseBodyResult> result;

    public static GetUserHolidaysResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserHolidaysResponseBody self = new GetUserHolidaysResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserHolidaysResponseBody setResult(java.util.List<GetUserHolidaysResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetUserHolidaysResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetUserHolidaysResponseBodyResultHolidays extends TeaModel {
        // 假期名称
        @NameInMap("holidayName")
        public String holidayName;

        // 假期类型，festival：法定节假日；rest：调休日；overtime：加班日；
        @NameInMap("holidayType")
        public String holidayType;

        // 补休日，只有假期类型为加班日时才有值
        @NameInMap("realWorkDate")
        public Long realWorkDate;

        // 日期
        @NameInMap("workDate")
        public Long workDate;

        public static GetUserHolidaysResponseBodyResultHolidays build(java.util.Map<String, ?> map) throws Exception {
            GetUserHolidaysResponseBodyResultHolidays self = new GetUserHolidaysResponseBodyResultHolidays();
            return TeaModel.build(map, self);
        }

        public GetUserHolidaysResponseBodyResultHolidays setHolidayName(String holidayName) {
            this.holidayName = holidayName;
            return this;
        }
        public String getHolidayName() {
            return this.holidayName;
        }

        public GetUserHolidaysResponseBodyResultHolidays setHolidayType(String holidayType) {
            this.holidayType = holidayType;
            return this;
        }
        public String getHolidayType() {
            return this.holidayType;
        }

        public GetUserHolidaysResponseBodyResultHolidays setRealWorkDate(Long realWorkDate) {
            this.realWorkDate = realWorkDate;
            return this;
        }
        public Long getRealWorkDate() {
            return this.realWorkDate;
        }

        public GetUserHolidaysResponseBodyResultHolidays setWorkDate(Long workDate) {
            this.workDate = workDate;
            return this;
        }
        public Long getWorkDate() {
            return this.workDate;
        }

    }

    public static class GetUserHolidaysResponseBodyResult extends TeaModel {
        // 假期列表
        @NameInMap("holidays")
        public java.util.List<GetUserHolidaysResponseBodyResultHolidays> holidays;

        // 员工id
        @NameInMap("userId")
        public String userId;

        public static GetUserHolidaysResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserHolidaysResponseBodyResult self = new GetUserHolidaysResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserHolidaysResponseBodyResult setHolidays(java.util.List<GetUserHolidaysResponseBodyResultHolidays> holidays) {
            this.holidays = holidays;
            return this;
        }
        public java.util.List<GetUserHolidaysResponseBodyResultHolidays> getHolidays() {
            return this.holidays;
        }

        public GetUserHolidaysResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
