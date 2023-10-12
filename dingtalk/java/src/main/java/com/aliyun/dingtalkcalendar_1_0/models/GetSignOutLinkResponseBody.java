// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutLinkResponseBody extends TeaModel {
    @NameInMap("signOutLink")
    public String signOutLink;

    public static GetSignOutLinkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutLinkResponseBody self = new GetSignOutLinkResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignOutLinkResponseBody setSignOutLink(String signOutLink) {
        this.signOutLink = signOutLink;
        return this;
    }
    public String getSignOutLink() {
        return this.signOutLink;
    }

}
