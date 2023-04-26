// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClosingAccountsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetClosingAccountsResponseBodyResult> result;

    public static GetClosingAccountsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetClosingAccountsResponseBody self = new GetClosingAccountsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetClosingAccountsResponseBody setResult(java.util.List<GetClosingAccountsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetClosingAccountsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetClosingAccountsResponseBodyResultClosingAccountModel extends TeaModel {
        @NameInMap("closingDay")
        public Integer closingDay;

        @NameInMap("closingHourMinutes")
        public Long closingHourMinutes;

        @NameInMap("endDay")
        public Integer endDay;

        @NameInMap("endMonth")
        public Integer endMonth;

        @NameInMap("startDay")
        public Integer startDay;

        @NameInMap("startMonth")
        public Integer startMonth;

        public static GetClosingAccountsResponseBodyResultClosingAccountModel build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResultClosingAccountModel self = new GetClosingAccountsResponseBodyResultClosingAccountModel();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setClosingDay(Integer closingDay) {
            this.closingDay = closingDay;
            return this;
        }
        public Integer getClosingDay() {
            return this.closingDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setClosingHourMinutes(Long closingHourMinutes) {
            this.closingHourMinutes = closingHourMinutes;
            return this;
        }
        public Long getClosingHourMinutes() {
            return this.closingHourMinutes;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndDay(Integer endDay) {
            this.endDay = endDay;
            return this;
        }
        public Integer getEndDay() {
            return this.endDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndMonth(Integer endMonth) {
            this.endMonth = endMonth;
            return this;
        }
        public Integer getEndMonth() {
            return this.endMonth;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartDay(Integer startDay) {
            this.startDay = startDay;
            return this;
        }
        public Integer getStartDay() {
            return this.startDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartMonth(Integer startMonth) {
            this.startMonth = startMonth;
            return this;
        }
        public Integer getStartMonth() {
            return this.startMonth;
        }

    }

    public static class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel extends TeaModel {
        @NameInMap("invalidTimeStamp")
        public Long invalidTimeStamp;

        public static GetClosingAccountsResponseBodyResultUnsealClosingAccountModel build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResultUnsealClosingAccountModel self = new GetClosingAccountsResponseBodyResultUnsealClosingAccountModel();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel setInvalidTimeStamp(Long invalidTimeStamp) {
            this.invalidTimeStamp = invalidTimeStamp;
            return this;
        }
        public Long getInvalidTimeStamp() {
            return this.invalidTimeStamp;
        }

    }

    public static class GetClosingAccountsResponseBodyResult extends TeaModel {
        @NameInMap("closingAccountModel")
        public GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel;

        @NameInMap("switchOn")
        public Boolean switchOn;

        @NameInMap("unsealClosingAccountModel")
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel;

        @NameInMap("userId")
        public String userId;

        public static GetClosingAccountsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResult self = new GetClosingAccountsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResult setClosingAccountModel(GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel) {
            this.closingAccountModel = closingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultClosingAccountModel getClosingAccountModel() {
            return this.closingAccountModel;
        }

        public GetClosingAccountsResponseBodyResult setSwitchOn(Boolean switchOn) {
            this.switchOn = switchOn;
            return this;
        }
        public Boolean getSwitchOn() {
            return this.switchOn;
        }

        public GetClosingAccountsResponseBodyResult setUnsealClosingAccountModel(GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel) {
            this.unsealClosingAccountModel = unsealClosingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel getUnsealClosingAccountModel() {
            return this.unsealClosingAccountModel;
        }

        public GetClosingAccountsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
