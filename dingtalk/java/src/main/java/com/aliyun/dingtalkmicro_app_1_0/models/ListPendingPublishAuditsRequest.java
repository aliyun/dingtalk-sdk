// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListPendingPublishAuditsRequest extends TeaModel {
    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("pageToken")
    public String pageToken;

    public static ListPendingPublishAuditsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPendingPublishAuditsRequest self = new ListPendingPublishAuditsRequest();
        return TeaModel.build(map, self);
    }

    public ListPendingPublishAuditsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListPendingPublishAuditsRequest setPageToken(String pageToken) {
        this.pageToken = pageToken;
        return this;
    }
    public String getPageToken() {
        return this.pageToken;
    }

}
