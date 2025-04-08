// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class MoveMailFolderRequest extends TeaModel {
    @NameInMap("destinationFolderId")
    public String destinationFolderId;

    public static MoveMailFolderRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveMailFolderRequest self = new MoveMailFolderRequest();
        return TeaModel.build(map, self);
    }

    public MoveMailFolderRequest setDestinationFolderId(String destinationFolderId) {
        this.destinationFolderId = destinationFolderId;
        return this;
    }
    public String getDestinationFolderId() {
        return this.destinationFolderId;
    }

}
