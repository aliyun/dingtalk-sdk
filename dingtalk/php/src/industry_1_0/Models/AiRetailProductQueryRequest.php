<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class AiRetailProductQueryRequest extends Model
{
    /**
     * @var string
     */
    public $productCode;

    /**
     * @var int
     */
    public $productId;
    protected $_name = [
        'productCode' => 'productCode',
        'productId' => 'productId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productId) {
            $res['productId'] = $this->productId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AiRetailProductQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productId'])) {
            $model->productId = $map['productId'];
        }

        return $model;
    }
}
