<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 物料名称
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 物料编号
     *
     * @var string
     */
    public $goodsNo;

    /**
     * @description 物料ID
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 规格
     *
     * @var string
     */
    public $productSpecs;

    /**
     * @description 计量单位
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'goodsName'    => 'goodsName',
        'goodsNo'      => 'goodsNo',
        'instanceId'   => 'instanceId',
        'productSpecs' => 'productSpecs',
        'unit'         => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->goodsNo) {
            $res['goodsNo'] = $this->goodsNo;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->productSpecs) {
            $res['productSpecs'] = $this->productSpecs;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['goodsNo'])) {
            $model->goodsNo = $map['goodsNo'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['productSpecs'])) {
            $model->productSpecs = $map['productSpecs'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
