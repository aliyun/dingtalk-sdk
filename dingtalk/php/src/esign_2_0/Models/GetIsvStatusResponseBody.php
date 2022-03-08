<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetIsvStatusResponseBody extends Model
{
    /**
     * @var string
     */
    public $authStatus;

    /**
     * @var string
     */
    public $installStatus;
    protected $_name = [
        'authStatus'    => 'authStatus',
        'installStatus' => 'installStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authStatus) {
            $res['authStatus'] = $this->authStatus;
        }
        if (null !== $this->installStatus) {
            $res['installStatus'] = $this->installStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetIsvStatusResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authStatus'])) {
            $model->authStatus = $map['authStatus'];
        }
        if (isset($map['installStatus'])) {
            $model->installStatus = $map['installStatus'];
        }

        return $model;
    }
}
