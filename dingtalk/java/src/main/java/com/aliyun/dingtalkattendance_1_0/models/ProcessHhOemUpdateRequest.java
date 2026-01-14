// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessHhOemUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bindOemApp")
    public Boolean bindOemApp;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpIdList")
    public java.util.List<String> corpIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("useOemApp")
    public Boolean useOemApp;

    public static ProcessHhOemUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessHhOemUpdateRequest self = new ProcessHhOemUpdateRequest();
        return TeaModel.build(map, self);
    }

    public ProcessHhOemUpdateRequest setBindOemApp(Boolean bindOemApp) {
        this.bindOemApp = bindOemApp;
        return this;
    }
    public Boolean getBindOemApp() {
        return this.bindOemApp;
    }

    public ProcessHhOemUpdateRequest setCorpIdList(java.util.List<String> corpIdList) {
        this.corpIdList = corpIdList;
        return this;
    }
    public java.util.List<String> getCorpIdList() {
        return this.corpIdList;
    }

    public ProcessHhOemUpdateRequest setUseOemApp(Boolean useOemApp) {
        this.useOemApp = useOemApp;
        return this;
    }
    public Boolean getUseOemApp() {
        return this.useOemApp;
    }

}
