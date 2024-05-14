<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest\updateProcessInstanceRequests;

use AlibabaCloud\Tea\Model;

class notifiers extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example manager001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notifiers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
