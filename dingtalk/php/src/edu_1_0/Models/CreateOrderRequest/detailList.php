<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateOrderRequest;

use AlibabaCloud\Tea\Model;

class detailList extends Model
{
    /**
     * @description 商品名。
     *
     * @var string
     */
    public $itemName;

    /**
     * @description 场景。
     *
     * @var int
     */
    public $scene;

    /**
     * @description 应付金额，单位为分。
     *
     * @var int
     */
    public $itemAmount;

    /**
     * @description 计算优惠后的实付金额，单位为分。
     *
     * @var int
     */
    public $actualAmount;
    protected $_name = [
        'itemName'     => 'itemName',
        'scene'        => 'scene',
        'itemAmount'   => 'itemAmount',
        'actualAmount' => 'actualAmount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->itemAmount) {
            $res['itemAmount'] = $this->itemAmount;
        }
        if (null !== $this->actualAmount) {
            $res['actualAmount'] = $this->actualAmount;
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
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['itemAmount'])) {
            $model->itemAmount = $map['itemAmount'];
        }
        if (isset($map['actualAmount'])) {
            $model->actualAmount = $map['actualAmount'];
        }

        return $model;
    }
}
