// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageFileDownloadResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("downloadUrl")
    public String downloadUrl;

    public static RobotMessageFileDownloadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageFileDownloadResponseBody self = new RobotMessageFileDownloadResponseBody();
        return TeaModel.build(map, self);
    }

    public RobotMessageFileDownloadResponseBody setDownloadUrl(String downloadUrl) {
        this.downloadUrl = downloadUrl;
        return this;
    }
    public String getDownloadUrl() {
        return this.downloadUrl;
    }

}
