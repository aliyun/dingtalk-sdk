// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysRequest extends TeaModel {
    // 查询对象
    @NameInMap("topHolidayQueryParam")
    public GetUserHolidaysRequestTopHolidayQueryParam topHolidayQueryParam;

    public static GetUserHolidaysRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserHolidaysRequest self = new GetUserHolidaysRequest();
        return TeaModel.build(map, self);
    }

    public GetUserHolidaysRequest setTopHolidayQueryParam(GetUserHolidaysRequestTopHolidayQueryParam topHolidayQueryParam) {
        this.topHolidayQueryParam = topHolidayQueryParam;
        return this;
    }
    public GetUserHolidaysRequestTopHolidayQueryParam getTopHolidayQueryParam() {
        return this.topHolidayQueryParam;
    }

    public static class GetUserHolidaysRequestTopHolidayQueryParam extends TeaModel {
        // 员工列表，staffId
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        // 开始日期
        @NameInMap("workDateFrom")
        public Long workDateFrom;

        // 结束日期
        @NameInMap("workDateTo")
        public Long workDateTo;

        public static GetUserHolidaysRequestTopHolidayQueryParam build(java.util.Map<String, ?> map) throws Exception {
            GetUserHolidaysRequestTopHolidayQueryParam self = new GetUserHolidaysRequestTopHolidayQueryParam();
            return TeaModel.build(map, self);
        }

        public GetUserHolidaysRequestTopHolidayQueryParam setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

        public GetUserHolidaysRequestTopHolidayQueryParam setWorkDateFrom(Long workDateFrom) {
            this.workDateFrom = workDateFrom;
            return this;
        }
        public Long getWorkDateFrom() {
            return this.workDateFrom;
        }

        public GetUserHolidaysRequestTopHolidayQueryParam setWorkDateTo(Long workDateTo) {
            this.workDateTo = workDateTo;
            return this;
        }
        public Long getWorkDateTo() {
            return this.workDateTo;
        }

    }

}
