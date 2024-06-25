// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOpenUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://www.aliwork.com/fileHandle?appType=APP_VN7I6HVKUTXES7XX4OI8&fileName=2a4103a6-44d5-4114-990d-4147a2d53811.xlsx&instId=&type=download">https://www.aliwork.com/fileHandle?appType=APP_VN7I6HVKUTXES7XX4OI8&amp;fileName=2a4103a6-44d5-4114-990d-4147a2d53811.xlsx&amp;instId=&amp;type=download</a></p>
     */
    @NameInMap("fileUrl")
    public String fileUrl;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <strong>example:</strong>
     * <p>60000</p>
     */
    @NameInMap("timeout")
    public Long timeout;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetOpenUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOpenUrlRequest self = new GetOpenUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetOpenUrlRequest setFileUrl(String fileUrl) {
        this.fileUrl = fileUrl;
        return this;
    }
    public String getFileUrl() {
        return this.fileUrl;
    }

    public GetOpenUrlRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetOpenUrlRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetOpenUrlRequest setTimeout(Long timeout) {
        this.timeout = timeout;
        return this;
    }
    public Long getTimeout() {
        return this.timeout;
    }

    public GetOpenUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
