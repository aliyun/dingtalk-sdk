// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PollingConfirmStatusRequest extends TeaModel {
    @NameInMap("courseCode")
    public String courseCode;

    @NameInMap("ext")
    public String ext;

    @NameInMap("isvCode")
    public String isvCode;

    @NameInMap("opUserId")
    public String opUserId;

    public static PollingConfirmStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        PollingConfirmStatusRequest self = new PollingConfirmStatusRequest();
        return TeaModel.build(map, self);
    }

    public PollingConfirmStatusRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public PollingConfirmStatusRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public PollingConfirmStatusRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public PollingConfirmStatusRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
