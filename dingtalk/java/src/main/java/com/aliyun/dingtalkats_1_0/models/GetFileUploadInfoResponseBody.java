// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("accessToken")
    public String accessToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1626923829000</p>
     */
    @NameInMap("accessTokenExpirationMillis")
    public Long accessTokenExpirationMillis;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lippi-space-zjk</p>
     */
    @NameInMap("bucket")
    public String bucket;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>oss-cn-zhangjiakou.aliyuncs.com</p>
     */
    @NameInMap("endPoint")
    public String endPoint;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static GetFileUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoResponseBody self = new GetFileUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public GetFileUploadInfoResponseBody setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public GetFileUploadInfoResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetFileUploadInfoResponseBody setAccessTokenExpirationMillis(Long accessTokenExpirationMillis) {
        this.accessTokenExpirationMillis = accessTokenExpirationMillis;
        return this;
    }
    public Long getAccessTokenExpirationMillis() {
        return this.accessTokenExpirationMillis;
    }

    public GetFileUploadInfoResponseBody setBucket(String bucket) {
        this.bucket = bucket;
        return this;
    }
    public String getBucket() {
        return this.bucket;
    }

    public GetFileUploadInfoResponseBody setEndPoint(String endPoint) {
        this.endPoint = endPoint;
        return this;
    }
    public String getEndPoint() {
        return this.endPoint;
    }

    public GetFileUploadInfoResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
