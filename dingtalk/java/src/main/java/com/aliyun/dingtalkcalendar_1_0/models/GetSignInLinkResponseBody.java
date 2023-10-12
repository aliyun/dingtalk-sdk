// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignInLinkResponseBody extends TeaModel {
    @NameInMap("signInLink")
    public String signInLink;

    public static GetSignInLinkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignInLinkResponseBody self = new GetSignInLinkResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignInLinkResponseBody setSignInLink(String signInLink) {
        this.signInLink = signInLink;
        return this;
    }
    public String getSignInLink() {
        return this.signInLink;
    }

}
