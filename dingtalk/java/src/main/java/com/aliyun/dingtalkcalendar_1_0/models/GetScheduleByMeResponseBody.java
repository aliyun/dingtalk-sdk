// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleByMeResponseBody extends TeaModel {
    @NameInMap("scheduleInformation")
    public java.util.List<GetScheduleByMeResponseBodyScheduleInformation> scheduleInformation;

    public static GetScheduleByMeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleByMeResponseBody self = new GetScheduleByMeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetScheduleByMeResponseBody setScheduleInformation(java.util.List<GetScheduleByMeResponseBodyScheduleInformation> scheduleInformation) {
        this.scheduleInformation = scheduleInformation;
        return this;
    }
    public java.util.List<GetScheduleByMeResponseBodyScheduleInformation> getScheduleInformation() {
        return this.scheduleInformation;
    }

    public static class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd self = new GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd();
            return TeaModel.build(map, self);
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart self = new GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart();
            return TeaModel.build(map, self);
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetScheduleByMeResponseBodyScheduleInformationScheduleItems extends TeaModel {
        @NameInMap("end")
        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd end;

        @NameInMap("start")
        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart start;

        /**
         * <strong>example:</strong>
         * <p>BUSY</p>
         */
        @NameInMap("status")
        public String status;

        public static GetScheduleByMeResponseBodyScheduleInformationScheduleItems build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleByMeResponseBodyScheduleInformationScheduleItems self = new GetScheduleByMeResponseBodyScheduleInformationScheduleItems();
            return TeaModel.build(map, self);
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItems setEnd(GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd end) {
            this.end = end;
            return this;
        }
        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd getEnd() {
            return this.end;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItems setStart(GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart start) {
            this.start = start;
            return this;
        }
        public GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart getStart() {
            return this.start;
        }

        public GetScheduleByMeResponseBodyScheduleInformationScheduleItems setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class GetScheduleByMeResponseBodyScheduleInformation extends TeaModel {
        @NameInMap("error")
        public String error;

        @NameInMap("scheduleItems")
        public java.util.List<GetScheduleByMeResponseBodyScheduleInformationScheduleItems> scheduleItems;

        @NameInMap("userId")
        public String userId;

        public static GetScheduleByMeResponseBodyScheduleInformation build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleByMeResponseBodyScheduleInformation self = new GetScheduleByMeResponseBodyScheduleInformation();
            return TeaModel.build(map, self);
        }

        public GetScheduleByMeResponseBodyScheduleInformation setError(String error) {
            this.error = error;
            return this;
        }
        public String getError() {
            return this.error;
        }

        public GetScheduleByMeResponseBodyScheduleInformation setScheduleItems(java.util.List<GetScheduleByMeResponseBodyScheduleInformationScheduleItems> scheduleItems) {
            this.scheduleItems = scheduleItems;
            return this;
        }
        public java.util.List<GetScheduleByMeResponseBodyScheduleInformationScheduleItems> getScheduleItems() {
            return this.scheduleItems;
        }

        public GetScheduleByMeResponseBodyScheduleInformation setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
