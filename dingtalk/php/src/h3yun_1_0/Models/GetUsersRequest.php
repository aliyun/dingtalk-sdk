<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUsersRequest extends Model
{
    /**
     * @description 部门id。
     *
     * @var string
     */
    public $departmentId;

    /**
     * @description 是否递归获取子级部门下的用户。默认值为false
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
