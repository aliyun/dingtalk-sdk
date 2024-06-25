// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageFileDownloadRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>mIofN681YE3f/+m+NntqpZSvSH2iMD6xP7Ow/ezdb1Wgn38tqVwL+zoRgzXipAMzmV5uhVKUlBdjKugAIvsm+TrvaPI0JYCMjvFMAlXvMWnMJsi2nZ9a0+N2c9CoV90hiB/B+fEThASPz+jmIa4J6x4WTsmmU3E/AopGsSGugE+hkHBcu52o76Yd2SCpPNUqenvdySSqjowEt1+Ddz55/9Qj8Y8ZhTryqsb7tYwzLFB+F3lsWCotXBOQvEgy3e/bEQtOyV6YrP3KG6YNSb3Q==</p>
     */
    @NameInMap("downloadCode")
    public String downloadCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingue4kfzdxbyn0pjqd</p>
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
