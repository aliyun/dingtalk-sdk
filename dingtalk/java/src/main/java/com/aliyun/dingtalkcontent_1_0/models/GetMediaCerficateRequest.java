// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateRequest extends TeaModel {
    // 视频的文件名称,必须带扩展名,支持的扩展名参考:https://help.aliyun.com/document_detail/55396.htm?spm=a2c4g.11186623.2.11.2d385d4aG2IkCZ#title-j7o-gr4-c7a
    @NameInMap("fileName")
    public String fileName;

    // 入驻账号Id(请联系钉钉接口同学获取)
    @NameInMap("mcnId")
    public String mcnId;

    // 如果传入该值，表示续订该mediaId对应的上传凭证 ;否则将视为新建一个视频上传连接和凭证
    @NameInMap("mediaId")
    public String mediaId;

    // 视频介绍
    @NameInMap("mediaIntroduction")
    public String mediaIntroduction;

    // 视频的标题
    @NameInMap("mediaTitle")
    public String mediaTitle;

    // 自定义视频封面的URL地址
    @NameInMap("thumbUrl")
    public String thumbUrl;

    // 操作人的用户id
    @NameInMap("userId")
    public String userId;

    public static GetMediaCerficateRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMediaCerficateRequest self = new GetMediaCerficateRequest();
        return TeaModel.build(map, self);
    }

    public GetMediaCerficateRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetMediaCerficateRequest setMcnId(String mcnId) {
        this.mcnId = mcnId;
        return this;
    }
    public String getMcnId() {
        return this.mcnId;
    }

    public GetMediaCerficateRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public GetMediaCerficateRequest setMediaIntroduction(String mediaIntroduction) {
        this.mediaIntroduction = mediaIntroduction;
        return this;
    }
    public String getMediaIntroduction() {
        return this.mediaIntroduction;
    }

    public GetMediaCerficateRequest setMediaTitle(String mediaTitle) {
        this.mediaTitle = mediaTitle;
        return this;
    }
    public String getMediaTitle() {
        return this.mediaTitle;
    }

    public GetMediaCerficateRequest setThumbUrl(String thumbUrl) {
        this.thumbUrl = thumbUrl;
        return this;
    }
    public String getThumbUrl() {
        return this.thumbUrl;
    }

    public GetMediaCerficateRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
