// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenTerminalInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingf8d907412a586</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>云枢</p>
     */
    @NameInMap("logSource")
    public String logSource;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>terminalInfo</p>
     */
    @NameInMap("logType")
    public String logType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>[{&quot;date&quot;:&quot;2023-05-10&quot;,&quot;macAddress&quot;:&quot;34-2E-B7-AF-EA-JF&quot;,&quot;devSn&quot;:&quot;68D1F0-B76A-5CC9-BCFC-BD7548BA&quot;,&quot;staffId&quot;:&quot;05166141678164&quot;}]</p>
     */
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
