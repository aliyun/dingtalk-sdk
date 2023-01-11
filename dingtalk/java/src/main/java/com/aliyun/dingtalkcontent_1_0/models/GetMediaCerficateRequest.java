// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateRequest extends TeaModel {
    /**
     * <p>视频的文件名称,必须带扩展名,支持的扩展名参考:https://help.aliyun.com/document_detail/55396.htm?spm=a2c4g.11186623.2.11.2d385d4aG2IkCZ#title-j7o-gr4-c7a</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>入驻账号Id(请联系钉钉接口同学获取)</p>
     */
    @NameInMap("mcnId")
    public String mcnId;

    /**
     * <p>如果传入该值，表示续订该mediaId对应的上传凭证 ;否则将视为新建一个视频上传连接和凭证</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>视频介绍</p>
     */
    @NameInMap("mediaIntroduction")
    public String mediaIntroduction;

    /**
     * <p>视频的标题</p>
     */
    @NameInMap("mediaTitle")
    public String mediaTitle;

    /**
     * <p>自定义视频封面的URL地址</p>
     */
    @NameInMap("thumbUrl")
    public String thumbUrl;

    /**
     * <p>操作人的用户id</p>
     */
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
