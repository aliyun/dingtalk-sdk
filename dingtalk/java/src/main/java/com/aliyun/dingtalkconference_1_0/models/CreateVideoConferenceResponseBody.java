// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateVideoConferenceResponseBody extends TeaModel {
    // conferenceId
    @NameInMap("conferenceId")
    public String conferenceId;

    // 会议密码
    @NameInMap("conferencePassword")
    public String conferencePassword;

    // 主持人密码
    @NameInMap("hostPassword")
    public String hostPassword;

    // 入会链接
    @NameInMap("externalLinkUrl")
    public String externalLinkUrl;

    // 电话入会号码
    @NameInMap("phoneNumbers")
    public java.util.List<String> phoneNumbers;

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

    public CreateVideoConferenceResponseBody setHostPassword(String hostPassword) {
        this.hostPassword = hostPassword;
        return this;
    }
    public String getHostPassword() {
        return this.hostPassword;
    }

    public CreateVideoConferenceResponseBody setExternalLinkUrl(String externalLinkUrl) {
        this.externalLinkUrl = externalLinkUrl;
        return this;
    }
    public String getExternalLinkUrl() {
        return this.externalLinkUrl;
    }

    public CreateVideoConferenceResponseBody setPhoneNumbers(java.util.List<String> phoneNumbers) {
        this.phoneNumbers = phoneNumbers;
        return this;
    }
    public java.util.List<String> getPhoneNumbers() {
        return this.phoneNumbers;
    }

}
