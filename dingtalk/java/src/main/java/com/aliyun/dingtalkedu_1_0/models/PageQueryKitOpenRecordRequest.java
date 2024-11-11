// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryKitOpenRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>course</p>
     */
    @NameInMap("isvProductScene")
    public String isvProductScene;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static PageQueryKitOpenRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        PageQueryKitOpenRecordRequest self = new PageQueryKitOpenRecordRequest();
        return TeaModel.build(map, self);
    }

    public PageQueryKitOpenRecordRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public PageQueryKitOpenRecordRequest setIsvProductScene(String isvProductScene) {
        this.isvProductScene = isvProductScene;
        return this;
    }
    public String getIsvProductScene() {
        return this.isvProductScene;
    }

    public PageQueryKitOpenRecordRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PageQueryKitOpenRecordRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
