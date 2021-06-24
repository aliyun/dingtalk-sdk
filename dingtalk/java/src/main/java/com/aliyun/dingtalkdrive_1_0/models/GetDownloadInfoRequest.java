// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetDownloadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoRequest self = new GetDownloadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
