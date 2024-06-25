// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateScheduleConferenceResponseBody extends TeaModel {
    @NameInMap("phones")
    public java.util.List<String> phones;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <strong>example:</strong>
     * <p>838 722 xxxxx</p>
     */
    @NameInMap("roomCode")
    public String roomCode;

    /**
     * <strong>example:</strong>
     * <p>2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx</p>
     */
    @NameInMap("scheduleConferenceId")
    public String scheduleConferenceId;

    /**
     * <strong>example:</strong>
     * <p><a href="https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9">https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9</a></p>
     */
    @NameInMap("url")
    public String url;

    public static CreateScheduleConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateScheduleConferenceResponseBody self = new CreateScheduleConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateScheduleConferenceResponseBody setPhones(java.util.List<String> phones) {
        this.phones = phones;
        return this;
    }
    public java.util.List<String> getPhones() {
        return this.phones;
    }

    public CreateScheduleConferenceResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateScheduleConferenceResponseBody setRoomCode(String roomCode) {
        this.roomCode = roomCode;
        return this;
    }
    public String getRoomCode() {
        return this.roomCode;
    }

    public CreateScheduleConferenceResponseBody setScheduleConferenceId(String scheduleConferenceId) {
        this.scheduleConferenceId = scheduleConferenceId;
        return this;
    }
    public String getScheduleConferenceId() {
        return this.scheduleConferenceId;
    }

    public CreateScheduleConferenceResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
