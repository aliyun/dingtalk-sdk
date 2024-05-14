// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateVideoConferenceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conferenceId")
    public String conferenceId;

    @NameInMap("conferencePassword")
    public String conferencePassword;

    @NameInMap("externalLinkUrl")
    public String externalLinkUrl;

    @NameInMap("hostPassword")
    public String hostPassword;

    @NameInMap("phoneNumbers")
    public java.util.List<String> phoneNumbers;

    @NameInMap("roomCode")
    public String roomCode;

    public static CreateVideoConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateVideoConferenceResponseBody self = new CreateVideoConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateVideoConferenceResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public CreateVideoConferenceResponseBody setConferencePassword(String conferencePassword) {
        this.conferencePassword = conferencePassword;
        return this;
    }
    public String getConferencePassword() {
        return this.conferencePassword;
    }

    public CreateVideoConferenceResponseBody setExternalLinkUrl(String externalLinkUrl) {
        this.externalLinkUrl = externalLinkUrl;
        return this;
    }
    public String getExternalLinkUrl() {
        return this.externalLinkUrl;
    }

    public CreateVideoConferenceResponseBody setHostPassword(String hostPassword) {
        this.hostPassword = hostPassword;
        return this;
    }
    public String getHostPassword() {
        return this.hostPassword;
    }

    public CreateVideoConferenceResponseBody setPhoneNumbers(java.util.List<String> phoneNumbers) {
        this.phoneNumbers = phoneNumbers;
        return this;
    }
    public java.util.List<String> getPhoneNumbers() {
        return this.phoneNumbers;
    }

    public CreateVideoConferenceResponseBody setRoomCode(String roomCode) {
        this.roomCode = roomCode;
        return this;
    }
    public String getRoomCode() {
        return this.roomCode;
    }

}
