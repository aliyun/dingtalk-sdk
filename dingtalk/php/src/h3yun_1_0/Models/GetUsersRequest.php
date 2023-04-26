<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUsersRequest extends Model
{
    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $departmentId;

    /**
     * @example true
     *
     * @var bool
     */
    public $isRecursive;
    protected $_name = [
        'departmentId' => 'departmentId',
        'isRecursive'  => 'isRecursive',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->isRecursive) {
            $res['isRecursive'] = $this->isRecursive;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['isRecursive'])) {
            $model->isRecursive = $map['isRecursive'];
        }

        return $model;
    }
}
