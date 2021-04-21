// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class RenameFileRequest extends TeaModel {
    // 新文件名称
    @NameInMap("newFileName")
    public String newFileName;

    public static RenameFileRequest build(java.util.Map<String, ?> map) throws Exception {
        RenameFileRequest self = new RenameFileRequest();
        return TeaModel.build(map, self);
    }

    public RenameFileRequest setNewFileName(String newFileName) {
        this.newFileName = newFileName;
        return this;
    }
    public String getNewFileName() {
        return this.newFileName;
    }

}
