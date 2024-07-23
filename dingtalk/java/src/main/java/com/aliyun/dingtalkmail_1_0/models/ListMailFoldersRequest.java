// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class ListMailFoldersRequest extends TeaModel {
    @NameInMap("folderId")
    public String folderId;

    public static ListMailFoldersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMailFoldersRequest self = new ListMailFoldersRequest();
        return TeaModel.build(map, self);
    }

    public ListMailFoldersRequest setFolderId(String folderId) {
        this.folderId = folderId;
        return this;
    }
    public String getFolderId() {
        return this.folderId;
    }

}
