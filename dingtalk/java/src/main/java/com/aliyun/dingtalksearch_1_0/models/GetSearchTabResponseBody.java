// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchTabResponseBody extends TeaModel {
    // 创建时间
    @NameInMap("gmtCreate")
    public String gmtCreate;

    // 修改时间
    @NameInMap("gmtModified")
    public String gmtModified;

    // 数据源的id,范围为3000-4000
    @NameInMap("tabId")
    public Integer tabId;

    // 数据源名称
    @NameInMap("name")
    public String name;

    // 数据源优先级，数值越大优先级越高
    @NameInMap("priority")
    public Integer priority;

    // 数据源状态，1表示上线，0表示下线
    @NameInMap("status")
    public Integer status;

    public static GetSearchTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSearchTabResponseBody self = new GetSearchTabResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSearchTabResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public GetSearchTabResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public GetSearchTabResponseBody setTabId(Integer tabId) {
        this.tabId = tabId;
        return this;
    }
    public Integer getTabId() {
        return this.tabId;
    }

    public GetSearchTabResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSearchTabResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetSearchTabResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
