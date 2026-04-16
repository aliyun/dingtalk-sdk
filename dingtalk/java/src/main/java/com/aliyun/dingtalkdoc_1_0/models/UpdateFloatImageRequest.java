// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFloatImageRequest extends TeaModel {
    @NameInMap("anchor")
    public UpdateFloatImageRequestAnchor anchor;

    @NameInMap("coordinate")
    public UpdateFloatImageRequestCoordinate coordinate;

    @NameInMap("src")
    public String src;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateFloatImageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFloatImageRequest self = new UpdateFloatImageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFloatImageRequest setAnchor(UpdateFloatImageRequestAnchor anchor) {
        this.anchor = anchor;
        return this;
    }
    public UpdateFloatImageRequestAnchor getAnchor() {
        return this.anchor;
    }

    public UpdateFloatImageRequest setCoordinate(UpdateFloatImageRequestCoordinate coordinate) {
        this.coordinate = coordinate;
        return this;
    }
    public UpdateFloatImageRequestCoordinate getCoordinate() {
        return this.coordinate;
    }

    public UpdateFloatImageRequest setSrc(String src) {
        this.src = src;
        return this;
    }
    public String getSrc() {
        return this.src;
    }

    public UpdateFloatImageRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class UpdateFloatImageRequestAnchor extends TeaModel {
        @NameInMap("col")
        public Integer col;

        @NameInMap("row")
        public Integer row;

        public static UpdateFloatImageRequestAnchor build(java.util.Map<String, ?> map) throws Exception {
            UpdateFloatImageRequestAnchor self = new UpdateFloatImageRequestAnchor();
            return TeaModel.build(map, self);
        }

        public UpdateFloatImageRequestAnchor setCol(Integer col) {
            this.col = col;
            return this;
        }
        public Integer getCol() {
            return this.col;
        }

        public UpdateFloatImageRequestAnchor setRow(Integer row) {
            this.row = row;
            return this;
        }
        public Integer getRow() {
            return this.row;
        }

    }

    public static class UpdateFloatImageRequestCoordinate extends TeaModel {
        @NameInMap("height")
        public Double height;

        @NameInMap("offsetX")
        public Double offsetX;

        @NameInMap("offsetY")
        public Double offsetY;

        @NameInMap("width")
        public Double width;

        public static UpdateFloatImageRequestCoordinate build(java.util.Map<String, ?> map) throws Exception {
            UpdateFloatImageRequestCoordinate self = new UpdateFloatImageRequestCoordinate();
            return TeaModel.build(map, self);
        }

        public UpdateFloatImageRequestCoordinate setHeight(Double height) {
            this.height = height;
            return this;
        }
        public Double getHeight() {
            return this.height;
        }

        public UpdateFloatImageRequestCoordinate setOffsetX(Double offsetX) {
            this.offsetX = offsetX;
            return this;
        }
        public Double getOffsetX() {
            return this.offsetX;
        }

        public UpdateFloatImageRequestCoordinate setOffsetY(Double offsetY) {
            this.offsetY = offsetY;
            return this;
        }
        public Double getOffsetY() {
            return this.offsetY;
        }

        public UpdateFloatImageRequestCoordinate setWidth(Double width) {
            this.width = width;
            return this;
        }
        public Double getWidth() {
            return this.width;
        }

    }

}
