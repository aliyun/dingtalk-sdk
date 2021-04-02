<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteCrmFormInstanceRequest extends Model
{
    /**
     * @description 当前操作人id
     *
     * @var string
     */
    public $currentOperatorUserId;

    /**
     * @description 模版名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'currentOperatorUserId' => 'currentOperatorUserId',
        'name'                  => 'name',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteCrmFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currentOperatorUserId'])) {
            $model->currentOperatorUserId = $map['currentOperatorUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
