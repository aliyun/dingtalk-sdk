// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartStreamOutRequest extends TeaModel {
    @NameInMap("mode")
    public String mode;

    @NameInMap("needHostJoin")
    public Boolean needHostJoin;

    @NameInMap("smallWindowPosition")
    public String smallWindowPosition;

    @NameInMap("streamName")
    public String streamName;

    @NameInMap("streamUrlList")
    public java.util.List<String> streamUrlList;

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
