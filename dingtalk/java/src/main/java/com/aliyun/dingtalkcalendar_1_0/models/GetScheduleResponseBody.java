// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetScheduleResponseBody extends TeaModel {
    @NameInMap("scheduleInformation")
    public java.util.List<GetScheduleResponseBodyScheduleInformation> scheduleInformation;

    public static GetScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetScheduleResponseBody self = new GetScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetScheduleResponseBody setScheduleInformation(java.util.List<GetScheduleResponseBodyScheduleInformation> scheduleInformation) {
        this.scheduleInformation = scheduleInformation;
        return this;
    }
    public java.util.List<GetScheduleResponseBodyScheduleInformation> getScheduleInformation() {
        return this.scheduleInformation;
    }

    public static class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetScheduleResponseBodyScheduleInformationScheduleItemsEnd build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleResponseBodyScheduleInformationScheduleItemsEnd self = new GetScheduleResponseBodyScheduleInformationScheduleItemsEnd();
            return TeaModel.build(map, self);
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetScheduleResponseBodyScheduleInformationScheduleItemsStart extends TeaModel {
        @NameInMap("date")
        public String date;

        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetScheduleResponseBodyScheduleInformationScheduleItemsStart build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleResponseBodyScheduleInformationScheduleItemsStart self = new GetScheduleResponseBodyScheduleInformationScheduleItemsStart();
            return TeaModel.build(map, self);
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsStart setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItemsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetScheduleResponseBodyScheduleInformationScheduleItems extends TeaModel {
        @NameInMap("end")
        public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd end;

        @NameInMap("start")
        public GetScheduleResponseBodyScheduleInformationScheduleItemsStart start;

        @NameInMap("status")
        public String status;

        public static GetScheduleResponseBodyScheduleInformationScheduleItems build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleResponseBodyScheduleInformationScheduleItems self = new GetScheduleResponseBodyScheduleInformationScheduleItems();
            return TeaModel.build(map, self);
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItems setEnd(GetScheduleResponseBodyScheduleInformationScheduleItemsEnd end) {
            this.end = end;
            return this;
        }
        public GetScheduleResponseBodyScheduleInformationScheduleItemsEnd getEnd() {
            return this.end;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItems setStart(GetScheduleResponseBodyScheduleInformationScheduleItemsStart start) {
            this.start = start;
            return this;
        }
        public GetScheduleResponseBodyScheduleInformationScheduleItemsStart getStart() {
            return this.start;
        }

        public GetScheduleResponseBodyScheduleInformationScheduleItems setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class GetScheduleResponseBodyScheduleInformation extends TeaModel {
        @NameInMap("error")
        public String error;

        @NameInMap("scheduleItems")
        public java.util.List<GetScheduleResponseBodyScheduleInformationScheduleItems> scheduleItems;

        @NameInMap("userId")
        public String userId;

        public static GetScheduleResponseBodyScheduleInformation build(java.util.Map<String, ?> map) throws Exception {
            GetScheduleResponseBodyScheduleInformation self = new GetScheduleResponseBodyScheduleInformation();
            return TeaModel.build(map, self);
        }

        public GetScheduleResponseBodyScheduleInformation setError(String error) {
            this.error = error;
            return this;
        }
        public String getError() {
            return this.error;
        }

        public GetScheduleResponseBodyScheduleInformation setScheduleItems(java.util.List<GetScheduleResponseBodyScheduleInformationScheduleItems> scheduleItems) {
            this.scheduleItems = scheduleItems;
            return this;
        }
        public java.util.List<GetScheduleResponseBodyScheduleInformationScheduleItems> getScheduleItems() {
            return this.scheduleItems;
        }

        public GetScheduleResponseBodyScheduleInformation setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
