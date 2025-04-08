// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DeleteMessagesRequest extends TeaModel {
    @NameInMap("deleteType")
    public String deleteType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ids")
    public java.util.List<String> ids;

    public static DeleteMessagesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMessagesRequest self = new DeleteMessagesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMessagesRequest setDeleteType(String deleteType) {
        this.deleteType = deleteType;
        return this;
    }
    public String getDeleteType() {
        return this.deleteType;
    }

    public DeleteMessagesRequest setIds(java.util.List<String> ids) {
        this.ids = ids;
        return this;
    }
    public java.util.List<String> getIds() {
        return this.ids;
    }

}
