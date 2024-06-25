// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceLogRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xdfsf20001</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sn123</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>file：普通文件</p>
     */
    @NameInMap("type")
    public String type;

    public static ReportDeviceLogRequest build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceLogRequest self = new ReportDeviceLogRequest();
        return TeaModel.build(map, self);
    }

    public ReportDeviceLogRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public ReportDeviceLogRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ReportDeviceLogRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
