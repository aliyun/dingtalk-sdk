// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class AddAttendeeHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-client-token")
    public String xClientToken;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static AddAttendeeHeaders build(java.util.Map<String, ?> map) throws Exception {
        AddAttendeeHeaders self = new AddAttendeeHeaders();
        return TeaModel.build(map, self);
    }

    public AddAttendeeHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public AddAttendeeHeaders setXClientToken(String xClientToken) {
        this.xClientToken = xClientToken;
        return this;
    }
    public String getXClientToken() {
        return this.xClientToken;
    }

    public AddAttendeeHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
