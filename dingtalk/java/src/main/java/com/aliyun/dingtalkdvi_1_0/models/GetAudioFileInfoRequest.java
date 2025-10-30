// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>A1</p>
     */
    @NameInMap("deviceType")
    public String deviceType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileId")
    public String fileId;

    public static GetAudioFileInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileInfoRequest self = new GetAudioFileInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAudioFileInfoRequest setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

    public GetAudioFileInfoRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

}
