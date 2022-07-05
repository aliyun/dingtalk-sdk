<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdatePermissionForUsersResponseBody extends Model
{
    /**
     * @var bool
     */
    public $isSuccess;
    protected $_name = [
        'isSuccess' => 'isSuccess',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSuccess) {
            $res['isSuccess'] = $this->isSuccess;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePermissionForUsersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSuccess'])) {
            $model->isSuccess = $map['isSuccess'];
        }

        return $model;
    }
}
