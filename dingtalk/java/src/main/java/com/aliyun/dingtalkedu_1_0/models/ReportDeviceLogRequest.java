// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceLogRequest extends TeaModel {
    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 文件id
    @NameInMap("mediaId")
    public String mediaId;

    // 文件类型
    @NameInMap("type")
    public String type;

    public static ReportDeviceLogRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceLogRequest self = new ReportDeviceLogRequest();
        return TeaModel.build(map, self);
    }

    public ReportDeviceLogRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ReportDeviceLogRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public ReportDeviceLogRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
