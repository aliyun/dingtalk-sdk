// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUploadInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaType")
    public String mediaType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("resourceName")
    public String resourceName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("size")
    public Long size;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetResourceUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUploadInfoRequest self = new GetResourceUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetResourceUploadInfoRequest setMediaType(String mediaType) {
        this.mediaType = mediaType;
        return this;
    }
    public String getMediaType() {
        return this.mediaType;
    }

    public GetResourceUploadInfoRequest setResourceName(String resourceName) {
        this.resourceName = resourceName;
        return this;
    }
    public String getResourceName() {
        return this.resourceName;
    }

    public GetResourceUploadInfoRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

    public GetResourceUploadInfoRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
