// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteFileRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 删除策略
    @NameInMap("deletePolicy")
    public String deletePolicy;

    public static DeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFileRequest self = new DeleteFileRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public DeleteFileRequest setDeletePolicy(String deletePolicy) {
        this.deletePolicy = deletePolicy;
        return this;
    }
    public String getDeletePolicy() {
        return this.deletePolicy;
    }

}
