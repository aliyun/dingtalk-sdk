// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteFileRequest extends TeaModel {
    @NameInMap("deletePolicy")
    public String deletePolicy;

    @NameInMap("unionId")
    public String unionId;

    public static DeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFileRequest self = new DeleteFileRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFileRequest setDeletePolicy(String deletePolicy) {
        this.deletePolicy = deletePolicy;
        return this;
    }
    public String getDeletePolicy() {
        return this.deletePolicy;
    }

    public DeleteFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
