<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderFlowRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @description 计算优惠后的实付金额，单位为分
     *
     * @var int
     */
    public $actualAmount;

    /**
     * @description 应付金额，单位为分
     *
     * @var int
     */
    public $itemAmount;

    /**
     * @description 商品id
     *
     * @var int
     */
    public $itemId;

    /**
     * @description 商品名
     *
     * @var string
     */
    public $itemName;

    /**
     * @description 场景
     *
     * @var int
     */
    public $scene;
    protected $_name = [
        'actualAmount' => 'actualAmount',
        'itemAmount'   => 'itemAmount',
        'itemId'       => 'itemId',
        'itemName'     => 'itemName',
        'scene'        => 'scene',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
        }
        if (null !== $this->itemAmount) {
            $res['itemAmount'] = $this->itemAmount;
        }
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }
        if (isset($map['itemAmount'])) {
            $model->itemAmount = $map['itemAmount'];
        }
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }

        return $model;
    }
}
