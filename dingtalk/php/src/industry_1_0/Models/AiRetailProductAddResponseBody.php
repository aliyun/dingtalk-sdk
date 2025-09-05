<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class AiRetailProductAddResponseBody extends Model
{
    /**
     * @var int
     */
    public $productId;
    protected $_name = [
        'productId' => 'productId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->productId) {
            $res['productId'] = $this->productId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AiRetailProductAddResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['productId'])) {
            $model->productId = $map['productId'];
        }

        return $model;
    }
}
