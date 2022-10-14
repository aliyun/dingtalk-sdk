// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosRequest extends TeaModel {
    // 分片id列表
    // 分片id取值: 1~10000
    // 分片大小限制: 100KB~5GB
    @NameInMap("partNumbers")
    public java.util.List<Integer> partNumbers;

    // 上传唯一标识
    @NameInMap("uploadKey")
    public String uploadKey;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetMultipartFileUploadInfosRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMultipartFileUploadInfosRequest self = new GetMultipartFileUploadInfosRequest();
        return TeaModel.build(map, self);
    }

    public GetMultipartFileUploadInfosRequest setPartNumbers(java.util.List<Integer> partNumbers) {
        this.partNumbers = partNumbers;
        return this;
    }
    public java.util.List<Integer> getPartNumbers() {
        return this.partNumbers;
    }

    public GetMultipartFileUploadInfosRequest setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public GetMultipartFileUploadInfosRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
