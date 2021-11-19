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
     * @description 是否向授权人发消息
     *
     * @var bool
     */
    public $sendMsg;

    /**
     * @description 权限范围
     *
     * @var scope
     */
    public $scope;
    protected $_name = [
        'privilege' => 'privilege',
        'sendMsg'   => 'sendMsg',
        'scope'     => 'scope',
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
        if (null !== $this->sendMsg) {
            $res['sendMsg'] = $this->sendMsg;
        }
        if (null !== $this->scope) {
            $res['scope'] = null !== $this->scope ? $this->scope->toMap() : null;
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
        if (isset($map['sendMsg'])) {
            $model->sendMsg = $map['sendMsg'];
        }
        if (isset($map['scope'])) {
            $model->scope = scope::fromMap($map['scope']);
        }

        return $model;
    }
}
