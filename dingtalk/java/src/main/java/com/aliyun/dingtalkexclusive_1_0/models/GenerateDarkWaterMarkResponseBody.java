// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GenerateDarkWaterMarkResponseBody extends TeaModel {
    @NameInMap("darkWatermarkVOList")
    public java.util.List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> darkWatermarkVOList;

    public static GenerateDarkWaterMarkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GenerateDarkWaterMarkResponseBody self = new GenerateDarkWaterMarkResponseBody();
        return TeaModel.build(map, self);
    }

    public GenerateDarkWaterMarkResponseBody setDarkWatermarkVOList(java.util.List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> darkWatermarkVOList) {
        this.darkWatermarkVOList = darkWatermarkVOList;
        return this;
    }
    public java.util.List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> getDarkWatermarkVOList() {
        return this.darkWatermarkVOList;
    }

    public static class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList extends TeaModel {
        @NameInMap("darkWatermark")
        public String darkWatermark;

        @NameInMap("userId")
        public String userId;

        public static GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList build(java.util.Map<String, ?> map) throws Exception {
            GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList self = new GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList();
            return TeaModel.build(map, self);
        }

        public GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList setDarkWatermark(String darkWatermark) {
            this.darkWatermark = darkWatermark;
            return this;
        }
        public String getDarkWatermark() {
            return this.darkWatermark;
        }

        public GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
