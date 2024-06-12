// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class MeetingRoomRespondHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("userAgent")
    public String userAgent;

    @NameInMap("x-client-token")
    public String xClientToken;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static MeetingRoomRespondHeaders build(java.util.Map<String, ?> map) throws Exception {
        MeetingRoomRespondHeaders self = new MeetingRoomRespondHeaders();
        return TeaModel.build(map, self);
    }

    public MeetingRoomRespondHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public MeetingRoomRespondHeaders setUserAgent(String userAgent) {
        this.userAgent = userAgent;
        return this;
    }
    public String getUserAgent() {
        return this.userAgent;
    }

    public MeetingRoomRespondHeaders setXClientToken(String xClientToken) {
        this.xClientToken = xClientToken;
        return this;
    }
    public String getXClientToken() {
        return this.xClientToken;
    }

    public MeetingRoomRespondHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
