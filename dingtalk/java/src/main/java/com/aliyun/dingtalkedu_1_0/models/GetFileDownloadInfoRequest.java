// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileIdList")
    public java.util.List<String> fileIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceId")
    public Long spaceId;

    public static GetFileDownloadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoRequest self = new GetFileDownloadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoRequest setFileIdList(java.util.List<String> fileIdList) {
        this.fileIdList = fileIdList;
        return this;
    }
    public java.util.List<String> getFileIdList() {
        return this.fileIdList;
    }

    public GetFileDownloadInfoRequest setSpaceId(Long spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public Long getSpaceId() {
        return this.spaceId;
    }

}
