// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyun_shu_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenExternalLogRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("logSource")
    public String logSource;

    @NameInMap("logType")
    public String logType;

    @NameInMap("openExt")
    public String openExt;

    public static SaveOpenExternalLogRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenExternalLogRequest self = new SaveOpenExternalLogRequest();
        return TeaModel.build(map, self);
    }

    public SaveOpenExternalLogRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveOpenExternalLogRequest setLogSource(String logSource) {
        this.logSource = logSource;
        return this;
    }
    public String getLogSource() {
        return this.logSource;
    }

    public SaveOpenExternalLogRequest setLogType(String logType) {
        this.logType = logType;
        return this;
    }
    public String getLogType() {
        return this.logType;
    }

    public SaveOpenExternalLogRequest setOpenExt(String openExt) {
        this.openExt = openExt;
        return this;
    }
    public String getOpenExt() {
        return this.openExt;
    }

}
