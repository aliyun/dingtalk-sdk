<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateAutoLoginUrlResponseBody\loginInfo;
use AlibabaCloud\Tea\Model;

class CreateAutoLoginUrlResponseBody extends Model
{
    /**
     * @var loginInfo
     */
    public $loginInfo;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'loginInfo' => 'loginInfo',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->loginInfo) {
            $res['loginInfo'] = null !== $this->loginInfo ? $this->loginInfo->toMap() : null;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAutoLoginUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['loginInfo'])) {
            $model->loginInfo = loginInfo::fromMap($map['loginInfo']);
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
