<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\PreCreateGroupBillOrderResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2023100914312930910100002107362525
     *
     * @var string
     */
    public $orderNo;
    protected $_name = [
        'orderNo' => 'orderNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }

        return $model;
    }
}
