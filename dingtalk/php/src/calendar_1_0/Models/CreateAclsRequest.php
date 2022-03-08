<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateAclsRequest\scope;
use AlibabaCloud\Tea\Model;

class CreateAclsRequest extends Model
{
    /**
     * @description 对日历的访问权限
     *
     * @var string
     */
    public $privilege;

    /**
     * @description 权限范围
     *
     * @var scope
     */
    public $scope;

    /**
     * @description 是否向授权人发消息
     *
     * @var bool
     */
    public $sendMsg;
    protected $_name = [
        'privilege' => 'privilege',
        'scope'     => 'scope',
        'sendMsg'   => 'sendMsg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->privilege) {
            $res['privilege'] = $this->privilege;
        }
        if (null !== $this->scope) {
            $res['scope'] = null !== $this->scope ? $this->scope->toMap() : null;
        }
        if (null !== $this->sendMsg) {
            $res['sendMsg'] = $this->sendMsg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAclsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['privilege'])) {
            $model->privilege = $map['privilege'];
        }
        if (isset($map['scope'])) {
            $model->scope = scope::fromMap($map['scope']);
        }
        if (isset($map['sendMsg'])) {
            $model->sendMsg = $map['sendMsg'];
        }

        return $model;
    }
}
