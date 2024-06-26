// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartStreamOutRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>grip</p>
     */
    @NameInMap("mode")
    public String mode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("needHostJoin")
    public Boolean needHostJoin;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("smallWindowPosition")
    public String smallWindowPosition;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>推流名称</p>
     */
    @NameInMap("streamName")
    public String streamName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("streamUrlList")
    public java.util.List<String> streamUrlList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>27SaQ3iiHLN0uwqcPisedfreNwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static StartStreamOutRequest build(java.util.Map<String, ?> map) throws Exception {
        StartStreamOutRequest self = new StartStreamOutRequest();
        return TeaModel.build(map, self);
    }

    public StartStreamOutRequest setMode(String mode) {
        this.mode = mode;
        return this;
    }
    public String getMode() {
        return this.mode;
    }

    public StartStreamOutRequest setNeedHostJoin(Boolean needHostJoin) {
        this.needHostJoin = needHostJoin;
        return this;
    }
    public Boolean getNeedHostJoin() {
        return this.needHostJoin;
    }

    public StartStreamOutRequest setSmallWindowPosition(String smallWindowPosition) {
        this.smallWindowPosition = smallWindowPosition;
        return this;
    }
    public String getSmallWindowPosition() {
        return this.smallWindowPosition;
    }

    public StartStreamOutRequest setStreamName(String streamName) {
        this.streamName = streamName;
        return this;
    }
    public String getStreamName() {
        return this.streamName;
    }

    public StartStreamOutRequest setStreamUrlList(java.util.List<String> streamUrlList) {
        this.streamUrlList = streamUrlList;
        return this;
    }
    public java.util.List<String> getStreamUrlList() {
        return this.streamUrlList;
    }

    public StartStreamOutRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
