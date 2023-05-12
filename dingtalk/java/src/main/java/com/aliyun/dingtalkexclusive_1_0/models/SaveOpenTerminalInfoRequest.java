// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenTerminalInfoRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("logSource")
    public String logSource;

    @NameInMap("logType")
    public String logType;

    @NameInMap("openExt")
    public String openExt;

    public static SaveOpenTerminalInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenTerminalInfoRequest self = new SaveOpenTerminalInfoRequest();
        return TeaModel.build(map, self);
    }

    public SaveOpenTerminalInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SaveOpenTerminalInfoRequest setLogSource(String logSource) {
        this.logSource = logSource;
        return this;
    }
    public String getLogSource() {
        return this.logSource;
    }

    public SaveOpenTerminalInfoRequest setLogType(String logType) {
        this.logType = logType;
        return this;
    }
    public String getLogType() {
        return this.logType;
    }

    public SaveOpenTerminalInfoRequest setOpenExt(String openExt) {
        this.openExt = openExt;
        return this;
    }
    public String getOpenExt() {
        return this.openExt;
    }

}
