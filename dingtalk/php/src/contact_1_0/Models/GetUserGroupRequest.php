<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserGroupRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupCode;
    protected $_name = [
        'groupCode' => 'groupCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }

        return $model;
    }
}
