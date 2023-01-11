// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetPictureDownloadUrlRequest extends TeaModel {
    /**
     * <p>服务窗机器人图片消息图片下载码。</p>
     * <p>开发者需要接入服务窗自建机器人后根据图片回调消息内容获取到对应的downloadCode。</p>
     */
    @NameInMap("downloadCode")
    public String downloadCode;

    /**
     * <p>服务窗机器人消息sessionId。</p>
     * <p>开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    public static GetPictureDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPictureDownloadUrlRequest self = new GetPictureDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetPictureDownloadUrlRequest setDownloadCode(String downloadCode) {
        this.downloadCode = downloadCode;
        return this;
    }
    public String getDownloadCode() {
        return this.downloadCode;
    }

    public GetPictureDownloadUrlRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
