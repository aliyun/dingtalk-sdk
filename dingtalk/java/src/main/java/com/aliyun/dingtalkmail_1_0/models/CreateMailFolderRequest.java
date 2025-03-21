// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateMailFolderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("displayName")
    public String displayName;

    @NameInMap("extensions")
    public java.util.Map<String, ?> extensions;

    @NameInMap("folerId")
    public String folerId;

    public static CreateMailFolderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateMailFolderRequest self = new CreateMailFolderRequest();
        return TeaModel.build(map, self);
    }

    public CreateMailFolderRequest setDisplayName(String displayName) {
        this.displayName = displayName;
        return this;
    }
    public String getDisplayName() {
        return this.displayName;
    }

    public CreateMailFolderRequest setExtensions(java.util.Map<String, ?> extensions) {
        this.extensions = extensions;
        return this;
    }
    public java.util.Map<String, ?> getExtensions() {
        return this.extensions;
    }

    public CreateMailFolderRequest setFolerId(String folerId) {
        this.folerId = folerId;
        return this;
    }
    public String getFolerId() {
        return this.folerId;
    }

}
