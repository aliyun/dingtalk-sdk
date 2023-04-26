// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilesRequest extends TeaModel {
    @NameInMap("deletePolicy")
    public String deletePolicy;

    @NameInMap("fileIds")
    public java.util.List<String> fileIds;

    @NameInMap("unionId")
    public String unionId;

    public static DeleteFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilesRequest self = new DeleteFilesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFilesRequest setDeletePolicy(String deletePolicy) {
        this.deletePolicy = deletePolicy;
        return this;
    }
    public String getDeletePolicy() {
        return this.deletePolicy;
    }

    public DeleteFilesRequest setFileIds(java.util.List<String> fileIds) {
        this.fileIds = fileIds;
        return this;
    }
    public java.util.List<String> getFileIds() {
        return this.fileIds;
    }

    public DeleteFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
