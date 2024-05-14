// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMailSendRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mail")
    public HrmMailSendRequestMail mail;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public HrmMailSendRequestOperator operator;

    public static HrmMailSendRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmMailSendRequest self = new HrmMailSendRequest();
        return TeaModel.build(map, self);
    }

    public HrmMailSendRequest setMail(HrmMailSendRequestMail mail) {
        this.mail = mail;
        return this;
    }
    public HrmMailSendRequestMail getMail() {
        return this.mail;
    }

    public HrmMailSendRequest setOperator(HrmMailSendRequestOperator operator) {
        this.operator = operator;
        return this;
    }
    public HrmMailSendRequestOperator getOperator() {
        return this.operator;
    }

    public static class HrmMailSendRequestMailAttachments extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("path")
        public String path;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static HrmMailSendRequestMailAttachments build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMailAttachments self = new HrmMailSendRequestMailAttachments();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMailAttachments setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrmMailSendRequestMailAttachments setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public HrmMailSendRequestMailAttachments setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class HrmMailSendRequestMailMeetingAlarm extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("alarmDesc")
        public String alarmDesc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("alarmMinutes")
        public Integer alarmMinutes;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("alarmSummary")
        public String alarmSummary;

        public static HrmMailSendRequestMailMeetingAlarm build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMailMeetingAlarm self = new HrmMailSendRequestMailMeetingAlarm();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMailMeetingAlarm setAlarmDesc(String alarmDesc) {
            this.alarmDesc = alarmDesc;
            return this;
        }
        public String getAlarmDesc() {
            return this.alarmDesc;
        }

        public HrmMailSendRequestMailMeetingAlarm setAlarmMinutes(Integer alarmMinutes) {
            this.alarmMinutes = alarmMinutes;
            return this;
        }
        public Integer getAlarmMinutes() {
            return this.alarmMinutes;
        }

        public HrmMailSendRequestMailMeetingAlarm setAlarmSummary(String alarmSummary) {
            this.alarmSummary = alarmSummary;
            return this;
        }
        public String getAlarmSummary() {
            return this.alarmSummary;
        }

    }

    public static class HrmMailSendRequestMailMeetingAttendees extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        public static HrmMailSendRequestMailMeetingAttendees build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMailMeetingAttendees self = new HrmMailSendRequestMailMeetingAttendees();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMailMeetingAttendees setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public HrmMailSendRequestMailMeetingAttendees setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class HrmMailSendRequestMailMeetingOrganizer extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        public static HrmMailSendRequestMailMeetingOrganizer build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMailMeetingOrganizer self = new HrmMailSendRequestMailMeetingOrganizer();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMailMeetingOrganizer setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public HrmMailSendRequestMailMeetingOrganizer setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class HrmMailSendRequestMailMeeting extends TeaModel {
        @NameInMap("alarm")
        public HrmMailSendRequestMailMeetingAlarm alarm;

        @NameInMap("attendees")
        public java.util.List<HrmMailSendRequestMailMeetingAttendees> attendees;

        @NameInMap("description")
        public String description;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("location")
        public String location;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("method")
        public String method;

        @NameInMap("organizer")
        public HrmMailSendRequestMailMeetingOrganizer organizer;

        @NameInMap("sequence")
        public Integer sequence;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("summary")
        public String summary;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("uuid")
        public String uuid;

        public static HrmMailSendRequestMailMeeting build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMailMeeting self = new HrmMailSendRequestMailMeeting();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMailMeeting setAlarm(HrmMailSendRequestMailMeetingAlarm alarm) {
            this.alarm = alarm;
            return this;
        }
        public HrmMailSendRequestMailMeetingAlarm getAlarm() {
            return this.alarm;
        }

        public HrmMailSendRequestMailMeeting setAttendees(java.util.List<HrmMailSendRequestMailMeetingAttendees> attendees) {
            this.attendees = attendees;
            return this;
        }
        public java.util.List<HrmMailSendRequestMailMeetingAttendees> getAttendees() {
            return this.attendees;
        }

        public HrmMailSendRequestMailMeeting setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public HrmMailSendRequestMailMeeting setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public HrmMailSendRequestMailMeeting setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public HrmMailSendRequestMailMeeting setMethod(String method) {
            this.method = method;
            return this;
        }
        public String getMethod() {
            return this.method;
        }

        public HrmMailSendRequestMailMeeting setOrganizer(HrmMailSendRequestMailMeetingOrganizer organizer) {
            this.organizer = organizer;
            return this;
        }
        public HrmMailSendRequestMailMeetingOrganizer getOrganizer() {
            return this.organizer;
        }

        public HrmMailSendRequestMailMeeting setSequence(Integer sequence) {
            this.sequence = sequence;
            return this;
        }
        public Integer getSequence() {
            return this.sequence;
        }

        public HrmMailSendRequestMailMeeting setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public HrmMailSendRequestMailMeeting setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public HrmMailSendRequestMailMeeting setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class HrmMailSendRequestMail extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<HrmMailSendRequestMailAttachments> attachments;

        @NameInMap("bccAddress")
        public String bccAddress;

        @NameInMap("ccAddress")
        public String ccAddress;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        @NameInMap("meeting")
        public HrmMailSendRequestMailMeeting meeting;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("receiverAddress")
        public String receiverAddress;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("senderAlias")
        public String senderAlias;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("subject")
        public String subject;

        public static HrmMailSendRequestMail build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestMail self = new HrmMailSendRequestMail();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestMail setAttachments(java.util.List<HrmMailSendRequestMailAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<HrmMailSendRequestMailAttachments> getAttachments() {
            return this.attachments;
        }

        public HrmMailSendRequestMail setBccAddress(String bccAddress) {
            this.bccAddress = bccAddress;
            return this;
        }
        public String getBccAddress() {
            return this.bccAddress;
        }

        public HrmMailSendRequestMail setCcAddress(String ccAddress) {
            this.ccAddress = ccAddress;
            return this;
        }
        public String getCcAddress() {
            return this.ccAddress;
        }

        public HrmMailSendRequestMail setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public HrmMailSendRequestMail setMeeting(HrmMailSendRequestMailMeeting meeting) {
            this.meeting = meeting;
            return this;
        }
        public HrmMailSendRequestMailMeeting getMeeting() {
            return this.meeting;
        }

        public HrmMailSendRequestMail setReceiverAddress(String receiverAddress) {
            this.receiverAddress = receiverAddress;
            return this;
        }
        public String getReceiverAddress() {
            return this.receiverAddress;
        }

        public HrmMailSendRequestMail setSenderAlias(String senderAlias) {
            this.senderAlias = senderAlias;
            return this;
        }
        public String getSenderAlias() {
            return this.senderAlias;
        }

        public HrmMailSendRequestMail setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

    }

    public static class HrmMailSendRequestOperator extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mailAccountType")
        public String mailAccountType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("token")
        public String token;

        public static HrmMailSendRequestOperator build(java.util.Map<String, ?> map) throws Exception {
            HrmMailSendRequestOperator self = new HrmMailSendRequestOperator();
            return TeaModel.build(map, self);
        }

        public HrmMailSendRequestOperator setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public HrmMailSendRequestOperator setMailAccountType(String mailAccountType) {
            this.mailAccountType = mailAccountType;
            return this;
        }
        public String getMailAccountType() {
            return this.mailAccountType;
        }

        public HrmMailSendRequestOperator setToken(String token) {
            this.token = token;
            return this;
        }
        public String getToken() {
            return this.token;
        }

    }

}
