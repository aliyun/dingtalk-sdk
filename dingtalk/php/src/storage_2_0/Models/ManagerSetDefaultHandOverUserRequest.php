<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class ManagerSetDefaultHandOverUserRequest extends Model
{
    /**
     * @example staff_id
     *
     * @var string
     */
    public $defaultHandoverUserId;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'defaultHandoverUserId' => 'defaultHandoverUserId',
        'operatorId'            => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultHandoverUserId) {
            $res['defaultHandoverUserId'] = $this->defaultHandoverUserId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManagerSetDefaultHandOverUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultHandoverUserId'])) {
            $model->defaultHandoverUserId = $map['defaultHandoverUserId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
