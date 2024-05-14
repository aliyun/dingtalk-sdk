// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageFileDownloadRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("downloadCode")
    public String downloadCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static RobotMessageFileDownloadRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageFileDownloadRequest self = new RobotMessageFileDownloadRequest();
        return TeaModel.build(map, self);
    }

    public RobotMessageFileDownloadRequest setDownloadCode(String downloadCode) {
        this.downloadCode = downloadCode;
        return this;
    }
    public String getDownloadCode() {
        return this.downloadCode;
    }

    public RobotMessageFileDownloadRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
