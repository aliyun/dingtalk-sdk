<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteCrmPersonalCustomerRequest extends Model
{
    /**
     * @description 操作人用户ID
     *
     * @var string
     */
    public $currentOperatorUserId;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->currentOperatorUserId) {
            $res['currentOperatorUserId'] = $this->currentOperatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteCrmPersonalCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currentOperatorUserId'])) {
            $model->currentOperatorUserId = $map['currentOperatorUserId'];
        }

        return $model;
    }
}
