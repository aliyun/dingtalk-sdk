<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwms_1_0\Models\QueryGoodsListResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 物料ID
     *
     * @var string
     */
    public $instanceId;

    /**
     * @description 物料编号
     *
     * @var string
     */
    public $goodsNo;

    /**
     * @description 物料名称
     *
     * @var string
     */
    public $goodsName;

    /**
     * @description 计量单位
     *
     * @var string
     */
    public $unit;

    /**
     * @description 规格
     *
     * @var string
     */
    public $productSpecs;
    protected $_name = [
        'instanceId'   => 'instanceId',
        'goodsNo'      => 'goodsNo',
        'goodsName'    => 'goodsName',
        'unit'         => 'unit',
        'productSpecs' => 'productSpecs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->goodsNo) {
            $res['goodsNo'] = $this->goodsNo;
        }
        if (null !== $this->goodsName) {
            $res['goodsName'] = $this->goodsName;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->productSpecs) {
            $res['productSpecs'] = $this->productSpecs;
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
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['goodsNo'])) {
            $model->goodsNo = $map['goodsNo'];
        }
        if (isset($map['goodsName'])) {
            $model->goodsName = $map['goodsName'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['productSpecs'])) {
            $model->productSpecs = $map['productSpecs'];
        }

        return $model;
    }
}
