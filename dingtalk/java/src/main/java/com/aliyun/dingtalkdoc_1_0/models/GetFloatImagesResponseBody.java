// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFloatImagesResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<GetFloatImagesResponseBodyValue> value;

    public static GetFloatImagesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFloatImagesResponseBody self = new GetFloatImagesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFloatImagesResponseBody setValue(java.util.List<GetFloatImagesResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<GetFloatImagesResponseBodyValue> getValue() {
        return this.value;
    }

    public static class GetFloatImagesResponseBodyValueAnchor extends TeaModel {
        @NameInMap("col")
        public Integer col;

        @NameInMap("row")
        public Integer row;

        public static GetFloatImagesResponseBodyValueAnchor build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImagesResponseBodyValueAnchor self = new GetFloatImagesResponseBodyValueAnchor();
            return TeaModel.build(map, self);
        }

        public GetFloatImagesResponseBodyValueAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public GetFloatImagesResponseBodyValueAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class GetFloatImagesResponseBodyValueCoordinate extends TeaModel {
        @NameInMap("height")
        public Double height;

        @NameInMap("offsetX")
        public Double offsetX;

        @NameInMap("offsetY")
        public Double offsetY;

        @NameInMap("width")
        public Double width;

        public static GetFloatImagesResponseBodyValueCoordinate build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImagesResponseBodyValueCoordinate self = new GetFloatImagesResponseBodyValueCoordinate();
            return TeaModel.build(map, self);
        }

        public GetFloatImagesResponseBodyValueCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public GetFloatImagesResponseBodyValueCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public GetFloatImagesResponseBodyValueCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public GetFloatImagesResponseBodyValueCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

    public static class GetFloatImagesResponseBodyValue extends TeaModel {
        @NameInMap("anchor")
        public GetFloatImagesResponseBodyValueAnchor anchor;

        @NameInMap("coordinate")
        public GetFloatImagesResponseBodyValueCoordinate coordinate;

        @NameInMap("id")
        public String id;

        @NameInMap("src")
        public String src;

        public static GetFloatImagesResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            GetFloatImagesResponseBodyValue self = new GetFloatImagesResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public GetFloatImagesResponseBodyValue setAnchor(GetFloatImagesResponseBodyValueAnchor anchor) {
            this.anchor = anchor;
            return this;
        }
        public GetFloatImagesResponseBodyValueAnchor getAnchor() {
            return this.anchor;
        }

        public GetFloatImagesResponseBodyValue setCoordinate(GetFloatImagesResponseBodyValueCoordinate coordinate) {
            this.coordinate = coordinate;
            return this;
        }
        public GetFloatImagesResponseBodyValueCoordinate getCoordinate() {
            return this.coordinate;
        }

        public GetFloatImagesResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetFloatImagesResponseBodyValue setSrc(String src) {
            this.src = src;
            return this;
        }
        public String getSrc() {
            return this.src;
        }

    }

}
