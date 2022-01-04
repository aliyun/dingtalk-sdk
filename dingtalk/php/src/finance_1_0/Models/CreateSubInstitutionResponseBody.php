<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateSubInstitutionResponseBody extends Model
{
    /**
     * @description 进件申请单号
     *
     * @var string
     */
    public $orderId;
    protected $_name = [
        'orderId' => 'orderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSubInstitutionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }

        return $model;
    }
}
