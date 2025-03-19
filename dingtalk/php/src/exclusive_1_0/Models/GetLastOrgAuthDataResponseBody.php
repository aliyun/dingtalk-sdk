<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLastOrgAuthDataResponseBody extends Model
{
    /**
     * @example 营业执照照片不清晰
     *
     * @var string
     */
    public $authRemark;

    /**
     * @example 2
     *
     * @var int
     */
    public $authStatus;
    protected $_name = [
        'authRemark' => 'authRemark',
        'authStatus' => 'authStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authRemark) {
            $res['authRemark'] = $this->authRemark;
        }
        if (null !== $this->authStatus) {
            $res['authStatus'] = $this->authStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLastOrgAuthDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authRemark'])) {
            $model->authRemark = $map['authRemark'];
        }
        if (isset($map['authStatus'])) {
            $model->authStatus = $map['authStatus'];
        }

        return $model;
    }
}
