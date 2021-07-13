// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClosingAccountsResponseBody extends TeaModel {
    // 规则列表
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
        // 封账时间-日
        @NameInMap("closingDay")
        public Integer closingDay;

        // 封账时间-时分
        @NameInMap("closingHourMinutes")
        public Long closingHourMinutes;

        // 封账范围-开始月
        @NameInMap("startMonth")
        public Integer startMonth;

        // 封账范围-开始日
        @NameInMap("startDay")
        public Integer startDay;

        // 封账范围-结束月
        @NameInMap("endMonth")
        public Integer endMonth;

        // 封账范围-结束日
        @NameInMap("endDay")
        public Integer endDay;

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

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartMonth(Integer startMonth) {
            this.startMonth = startMonth;
            return this;
        }
        public Integer getStartMonth() {
            return this.startMonth;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartDay(Integer startDay) {
            this.startDay = startDay;
            return this;
        }
        public Integer getStartDay() {
            return this.startDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndMonth(Integer endMonth) {
            this.endMonth = endMonth;
            return this;
        }
        public Integer getEndMonth() {
            return this.endMonth;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndDay(Integer endDay) {
            this.endDay = endDay;
            return this;
        }
        public Integer getEndDay() {
            return this.endDay;
        }

    }

    public static class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel extends TeaModel {
        // 解封时间点
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
        // 人员ID
        @NameInMap("userId")
        public String userId;

        // 开关
        @NameInMap("switchOn")
        public Boolean switchOn;

        // 封账规则
        @NameInMap("closingAccountModel")
        public GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel;

        // 解封规则
        @NameInMap("unsealClosingAccountModel")
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel;

        public static GetClosingAccountsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResult self = new GetClosingAccountsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetClosingAccountsResponseBodyResult setSwitchOn(Boolean switchOn) {
            this.switchOn = switchOn;
            return this;
        }
        public Boolean getSwitchOn() {
            return this.switchOn;
        }

        public GetClosingAccountsResponseBodyResult setClosingAccountModel(GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel) {
            this.closingAccountModel = closingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultClosingAccountModel getClosingAccountModel() {
            return this.closingAccountModel;
        }

        public GetClosingAccountsResponseBodyResult setUnsealClosingAccountModel(GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel) {
            this.unsealClosingAccountModel = unsealClosingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel getUnsealClosingAccountModel() {
            return this.unsealClosingAccountModel;
        }

    }

}
