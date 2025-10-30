// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetAudioFileDownloadInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deviceType")
    public String deviceType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>da5ad92d-79dc-4599-8f92-ba8209c68569</p>
     */
    @NameInMap("fileId")
    public String fileId;

    public static GetAudioFileDownloadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAudioFileDownloadInfoRequest self = new GetAudioFileDownloadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAudioFileDownloadInfoRequest setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

    public GetAudioFileDownloadInfoRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

}
