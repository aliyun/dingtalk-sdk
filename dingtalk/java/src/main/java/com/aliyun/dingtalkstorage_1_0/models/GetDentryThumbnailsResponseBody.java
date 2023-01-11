// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryThumbnailsResponseBody extends TeaModel {
    /**
     * <p>缩略图获取结果列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("resultItems")
    public java.util.List<GetDentryThumbnailsResponseBodyResultItems> resultItems;

    public static GetDentryThumbnailsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDentryThumbnailsResponseBody self = new GetDentryThumbnailsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDentryThumbnailsResponseBody setResultItems(java.util.List<GetDentryThumbnailsResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<GetDentryThumbnailsResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class GetDentryThumbnailsResponseBodyResultItemsThumbnail extends TeaModel {
        /**
         * <p>缩略图高度</p>
         */
        @NameInMap("height")
        public Integer height;

        /**
         * <p>缩略图url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>缩略图宽度</p>
         */
        @NameInMap("width")
        public Integer width;

        public static GetDentryThumbnailsResponseBodyResultItemsThumbnail build(java.util.Map<String, ?> map) throws Exception {
            GetDentryThumbnailsResponseBodyResultItemsThumbnail self = new GetDentryThumbnailsResponseBodyResultItemsThumbnail();
            return TeaModel.build(map, self);
        }

        public GetDentryThumbnailsResponseBodyResultItemsThumbnail setHeight(Integer height) {
            this.height = height;
            return this;
        }
        public Integer getHeight() {
            return this.height;
        }

        public GetDentryThumbnailsResponseBodyResultItemsThumbnail setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetDentryThumbnailsResponseBodyResultItemsThumbnail setWidth(Integer width) {
            this.width = width;
            return this;
        }
        public Integer getWidth() {
            return this.width;
        }

    }

    public static class GetDentryThumbnailsResponseBodyResultItems extends TeaModel {
        /**
         * <p>源文件(夹)id</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <p>错误原因</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>源文件(夹)空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>是否成功获取到缩略图</p>
         */
        @NameInMap("success")
        public Boolean success;

        /**
         * <p>缩略图信息</p>
         */
        @NameInMap("thumbnail")
        public GetDentryThumbnailsResponseBodyResultItemsThumbnail thumbnail;

        public static GetDentryThumbnailsResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetDentryThumbnailsResponseBodyResultItems self = new GetDentryThumbnailsResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public GetDentryThumbnailsResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public GetDentryThumbnailsResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public GetDentryThumbnailsResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public GetDentryThumbnailsResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public GetDentryThumbnailsResponseBodyResultItems setThumbnail(GetDentryThumbnailsResponseBodyResultItemsThumbnail thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public GetDentryThumbnailsResponseBodyResultItemsThumbnail getThumbnail() {
            return this.thumbnail;
        }

    }

}
