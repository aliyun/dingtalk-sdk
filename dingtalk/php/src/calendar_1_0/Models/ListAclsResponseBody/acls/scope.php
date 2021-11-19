<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAclsResponseBody\acls;

use AlibabaCloud\Tea\Model;

class scope extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 权限类型
     *
     * @var string
     */
    public $scopeType;
    protected $_name = [
        'userId'    => 'userId',
        'scopeType' => 'scopeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return scope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }

        return $model;
    }
}
