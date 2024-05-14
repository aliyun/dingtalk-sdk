// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteRemoteClassCourseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authCode")
    public String authCode;

    public static DeleteRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRemoteClassCourseRequest self = new DeleteRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRemoteClassCourseRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

}
