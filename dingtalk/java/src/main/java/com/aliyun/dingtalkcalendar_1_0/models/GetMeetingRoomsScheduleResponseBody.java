// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetMeetingRoomsScheduleResponseBody extends TeaModel {
    @NameInMap("scheduleInformation")
    public java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> scheduleInformation;

    public static GetMeetingRoomsScheduleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMeetingRoomsScheduleResponseBody self = new GetMeetingRoomsScheduleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMeetingRoomsScheduleResponseBody setScheduleInformation(java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> scheduleInformation) {
        this.scheduleInformation = scheduleInformation;
        return this;
    }
    public java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformation> getScheduleInformation() {
        return this.scheduleInformation;
    }

    public static class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd extends TeaModel {
        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd build(java.util.Map<String, ?> map) throws Exception {
            GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd self = new GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd();
            return TeaModel.build(map, self);
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer extends TeaModel {
        @NameInMap("id")
        public String id;

        public static GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer build(java.util.Map<String, ?> map) throws Exception {
            GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer self = new GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer();
            return TeaModel.build(map, self);
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

    public static class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart extends TeaModel {
        @NameInMap("dateTime")
        public String dateTime;

        @NameInMap("timeZone")
        public String timeZone;

        public static GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart build(java.util.Map<String, ?> map) throws Exception {
            GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart self = new GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart();
            return TeaModel.build(map, self);
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart setDateTime(String dateTime) {
            this.dateTime = dateTime;
            return this;
        }
        public String getDateTime() {
            return this.dateTime;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart setTimeZone(String timeZone) {
            this.timeZone = timeZone;
            return this;
        }
        public String getTimeZone() {
            return this.timeZone;
        }

    }

    public static class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems extends TeaModel {
        @NameInMap("end")
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd end;

        @NameInMap("eventId")
        public String eventId;

        @NameInMap("organizer")
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer organizer;

        @NameInMap("start")
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart start;

        @NameInMap("status")
        public String status;

        public static GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems build(java.util.Map<String, ?> map) throws Exception {
            GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems self = new GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems();
            return TeaModel.build(map, self);
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems setEnd(GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd end) {
            this.end = end;
            return this;
        }
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd getEnd() {
            return this.end;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems setEventId(String eventId) {
            this.eventId = eventId;
            return this;
        }
        public String getEventId() {
            return this.eventId;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems setOrganizer(GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer getOrganizer() {
            return this.organizer;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems setStart(GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart start) {
            this.start = start;
            return this;
        }
        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart getStart() {
            return this.start;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class GetMeetingRoomsScheduleResponseBodyScheduleInformation extends TeaModel {
        @NameInMap("error")
        public String error;

        @NameInMap("roomId")
        public String roomId;

        @NameInMap("scheduleItems")
        public java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> scheduleItems;

        public static GetMeetingRoomsScheduleResponseBodyScheduleInformation build(java.util.Map<String, ?> map) throws Exception {
            GetMeetingRoomsScheduleResponseBodyScheduleInformation self = new GetMeetingRoomsScheduleResponseBodyScheduleInformation();
            return TeaModel.build(map, self);
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformation setError(String error) {
            this.error = error;
            return this;
        }
        public String getError() {
            return this.error;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformation setRoomId(String roomId) {
            this.roomId = roomId;
            return this;
        }
        public String getRoomId() {
            return this.roomId;
        }

        public GetMeetingRoomsScheduleResponseBodyScheduleInformation setScheduleItems(java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> scheduleItems) {
            this.scheduleItems = scheduleItems;
            return this;
        }
        public java.util.List<GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems> getScheduleItems() {
            return this.scheduleItems;
        }

    }

}
