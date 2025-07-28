<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetTbUserIdByDingUserIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $dingtalkUserId;

    /**
     * @var string
     */
    public $tbUserId;
    protected $_name = [
        'dingtalkUserId' => 'dingtalkUserId',
        'tbUserId' => 'tbUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingtalkUserId) {
            $res['dingtalkUserId'] = $this->dingtalkUserId;
        }
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
        if (isset($map['dingtalkUserId'])) {
            $model->dingtalkUserId = $map['dingtalkUserId'];
        }
        if (isset($map['tbUserId'])) {
            $model->tbUserId = $map['tbUserId'];
        }

        return $model;
    }
}
