// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageFormBaseInfosRequest extends TeaModel {
    @NameInMap("appKey")
    public String appKey;

    @NameInMap("formTypeList")
    public java.util.List<String> formTypeList;

    @NameInMap("language")
    public String language;

    @NameInMap("pageIndex")
    public Integer pageIndex;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("userId")
    public String userId;

    public static PageFormBaseInfosRequest build(java.util.Map<String, ?> map) throws Exception {
        PageFormBaseInfosRequest self = new PageFormBaseInfosRequest();
        return TeaModel.build(map, self);
    }

    public PageFormBaseInfosRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public PageFormBaseInfosRequest setFormTypeList(java.util.List<String> formTypeList) {
        this.formTypeList = formTypeList;
        return this;
    }
    public java.util.List<String> getFormTypeList() {
        return this.formTypeList;
    }

    public PageFormBaseInfosRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public PageFormBaseInfosRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public PageFormBaseInfosRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public PageFormBaseInfosRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public PageFormBaseInfosRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
