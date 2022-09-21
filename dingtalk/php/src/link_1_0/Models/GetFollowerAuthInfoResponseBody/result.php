<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result\authInfo;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 授权详情
     *
     * @var authInfo
     */
    public $authInfo;
    protected $_name = [
        'authInfo' => 'authInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authInfo) {
            $res['authInfo'] = null !== $this->authInfo ? $this->authInfo->toMap() : null;
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
        if (isset($map['authInfo'])) {
            $model->authInfo = authInfo::fromMap($map['authInfo']);
        }

        return $model;
    }
}
