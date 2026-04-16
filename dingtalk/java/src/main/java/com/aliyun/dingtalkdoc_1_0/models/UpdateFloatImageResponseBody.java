// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFloatImageResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateFloatImageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateFloatImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFloatImageResponseBody self = new UpdateFloatImageResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFloatImageResponseBody setResult(UpdateFloatImageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateFloatImageResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateFloatImageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateFloatImageResponseBodyResultAnchor extends TeaModel {
        @NameInMap("col")
        public Integer col;

        @NameInMap("row")
        public Integer row;

        public static UpdateFloatImageResponseBodyResultAnchor build(java.util.Map<String, ?> map) throws Exception {
            UpdateFloatImageResponseBodyResultAnchor self = new UpdateFloatImageResponseBodyResultAnchor();
            return TeaModel.build(map, self);
        }

        public UpdateFloatImageResponseBodyResultAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public UpdateFloatImageResponseBodyResultAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class UpdateFloatImageResponseBodyResultCoordinate extends TeaModel {
        @NameInMap("height")
        public Double height;

        @NameInMap("offsetX")
        public Double offsetX;

        @NameInMap("offsetY")
        public Double offsetY;

        @NameInMap("width")
        public Double width;

        public static UpdateFloatImageResponseBodyResultCoordinate build(java.util.Map<String, ?> map) throws Exception {
            UpdateFloatImageResponseBodyResultCoordinate self = new UpdateFloatImageResponseBodyResultCoordinate();
            return TeaModel.build(map, self);
        }

        public UpdateFloatImageResponseBodyResultCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public UpdateFloatImageResponseBodyResultCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public UpdateFloatImageResponseBodyResultCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public UpdateFloatImageResponseBodyResultCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

    public static class UpdateFloatImageResponseBodyResult extends TeaModel {
        @NameInMap("anchor")
        public UpdateFloatImageResponseBodyResultAnchor anchor;

        @NameInMap("coordinate")
        public UpdateFloatImageResponseBodyResultCoordinate coordinate;

        @NameInMap("id")
        public String id;

        @NameInMap("src")
        public String src;

        public static UpdateFloatImageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateFloatImageResponseBodyResult self = new UpdateFloatImageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateFloatImageResponseBodyResult setAnchor(UpdateFloatImageResponseBodyResultAnchor anchor) {
            this.anchor = anchor;
            return this;
        }
        public UpdateFloatImageResponseBodyResultAnchor getAnchor() {
            return this.anchor;
        }

        public UpdateFloatImageResponseBodyResult setCoordinate(UpdateFloatImageResponseBodyResultCoordinate coordinate) {
            this.coordinate = coordinate;
            return this;
        }
        public UpdateFloatImageResponseBodyResultCoordinate getCoordinate() {
            return this.coordinate;
        }

        public UpdateFloatImageResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateFloatImageResponseBodyResult setSrc(String src) {
            this.src = src;
            return this;
        }
        public String getSrc() {
            return this.src;
        }

    }

}
