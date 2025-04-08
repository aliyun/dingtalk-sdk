// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMailFolderRequest extends TeaModel {
    @NameInMap("displayName")
    public String displayName;

    public static UpdateMailFolderRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMailFolderRequest self = new UpdateMailFolderRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMailFolderRequest setDisplayName(String displayName) {
        this.displayName = displayName;
        return this;
    }
    public String getDisplayName() {
        return this.displayName;
    }

}
