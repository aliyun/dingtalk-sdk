// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GenerateDarkWaterMarkResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>200</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://down-cdn.dingtalk.com/ddmedia/iAEKAqRmaWxlAwYEzh55BdsFzlFx040G2gAhhAGkC1HdIgKqLZPt3bUH2pAeUAPPAAABgRPQ5KgEzTBIBwAIAA.file">https://down-cdn.dingtalk.com/ddmedia/iAEKAqRmaWxlAwYEzh55BdsFzlFx040G2gAhhAGkC1HdIgKqLZPt3bUH2pAeUAPPAAABgRPQ5KgEzTBIBwAIAA.file</a></p>
         */
        @NameInMap("darkWatermark")
        public String darkWatermark;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0138350100401024915916</p>
         */
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
