// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateDevelopersRequest extends TeaModel {
    @NameInMap("noticeUrl")
    public String noticeUrl;

    public static CreateDevelopersRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDevelopersRequest self = new CreateDevelopersRequest();
        return TeaModel.build(map, self);
    }

    public CreateDevelopersRequest setNoticeUrl(String noticeUrl) {
        this.noticeUrl = noticeUrl;
        return this;
    }
    public String getNoticeUrl() {
        return this.noticeUrl;
    }

}
