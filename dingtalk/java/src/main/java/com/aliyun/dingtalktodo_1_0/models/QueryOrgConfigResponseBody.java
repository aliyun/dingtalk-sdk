// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgConfigResponseBody extends TeaModel {
    @NameInMap("appDisplayStyle")
    public String appDisplayStyle;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("homepageCatalogs")
    public java.util.List<String> homepageCatalogs;

    @NameInMap("modifiedTime")
    public Long modifiedTime;

    @NameInMap("status")
    public Integer status;

    public static QueryOrgConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgConfigResponseBody self = new QueryOrgConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgConfigResponseBody setAppDisplayStyle(String appDisplayStyle) {
        this.appDisplayStyle = appDisplayStyle;
        return this;
    }
    public String getAppDisplayStyle() {
        return this.appDisplayStyle;
    }

    public QueryOrgConfigResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public QueryOrgConfigResponseBody setHomepageCatalogs(java.util.List<String> homepageCatalogs) {
        this.homepageCatalogs = homepageCatalogs;
        return this;
    }
    public java.util.List<String> getHomepageCatalogs() {
        return this.homepageCatalogs;
    }

    public QueryOrgConfigResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public QueryOrgConfigResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
