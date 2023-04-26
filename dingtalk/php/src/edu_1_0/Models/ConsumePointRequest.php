<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConsumePointRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $amount;

    /**
     * @example 123
     *
     * @var string
     */
    public $bizId;

    /**
     * @example point_exchange
     *
     * @var string
     */
    public $description;

    /**
     * @example FAMILY_GIFT_MALL
     *
     * @var string
     */
    public $productCode;
    protected $_name = [
        'amount'      => 'amount',
        'bizId'       => 'bizId',
        'description' => 'description',
        'productCode' => 'productCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConsumePointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }

        return $model;
    }
}
