// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>1234567891234</p>
     */
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>1234567891234</p>
     */
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    @NameInMap("keyword")
    public String keyword;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>[&quot;xx&quot;,&quot;xxx&quot;]</p>
     */
    @NameInMap("processCodes")
    public String processCodes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetTaskCopiesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskCopiesRequest self = new GetTaskCopiesRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskCopiesRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetTaskCopiesRequest setCreateFromTimeGMT(Long createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public Long getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetTaskCopiesRequest setCreateToTimeGMT(Long createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public Long getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetTaskCopiesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public GetTaskCopiesRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetTaskCopiesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetTaskCopiesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetTaskCopiesRequest setProcessCodes(String processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public String getProcessCodes() {
        return this.processCodes;
    }

    public GetTaskCopiesRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetTaskCopiesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
