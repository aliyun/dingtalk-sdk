// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateDevelopersRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("noticeUrl")
    public String noticeUrl;

    public static CreateDevelopersRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDevelopersRequest self = new CreateDevelopersRequest();
        return TeaModel.build(map, self);
    }

    public CreateDevelopersRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateDevelopersRequest setNoticeUrl(String noticeUrl) {
        this.noticeUrl = noticeUrl;
        return this;
    }
    public String getNoticeUrl() {
        return this.noticeUrl;
    }

}
