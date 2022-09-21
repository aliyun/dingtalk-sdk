<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class ApplyFollowerAuthInfoRequest extends Model
{
    /**
     * @description 申请的授权数据，多个数据时使用,分隔
     *
     * @var string
     */
    public $fieldScope;

    /**
     * @description 客服会话sessionId
     *
     * @var string
     */
    public $sessionId;

    /**
     * @description 用户信息
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'fieldScope' => 'fieldScope',
        'sessionId'  => 'sessionId',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldScope) {
            $res['fieldScope'] = $this->fieldScope;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ApplyFollowerAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldScope'])) {
            $model->fieldScope = $map['fieldScope'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
