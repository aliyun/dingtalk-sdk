// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 是否返回区域信息
    @NameInMap("withRegion")
    public Boolean withRegion;

    // 是否返回内网加签url
    @NameInMap("withInternalResourceUrl")
    public Boolean withInternalResourceUrl;

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

    public GetDownloadInfoRequest setWithRegion(Boolean withRegion) {
        this.withRegion = withRegion;
        return this;
    }
    public Boolean getWithRegion() {
        return this.withRegion;
    }

    public GetDownloadInfoRequest setWithInternalResourceUrl(Boolean withInternalResourceUrl) {
        this.withInternalResourceUrl = withInternalResourceUrl;
        return this;
    }
    public Boolean getWithInternalResourceUrl() {
        return this.withInternalResourceUrl;
    }

}
