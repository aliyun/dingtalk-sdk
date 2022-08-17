<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbUserIdByStaffIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description Teambition用户id
     *
     * @var string
     */
    public $tbUserId;
    protected $_name = [
        'tbUserId' => 'tbUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tbUserId) {
            $res['tbUserId'] = $this->tbUserId;
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
        if (isset($map['tbUserId'])) {
            $model->tbUserId = $map['tbUserId'];
        }

        return $model;
    }
}
