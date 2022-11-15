<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddRobotToConversationRequest extends Model
{
    /**
     * @description 机器人meidaId
     *
     * @var string
     */
    public $icon;

    /**
     * @description 机器人名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 会话id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 机器人编码
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'icon'               => 'icon',
        'name'               => 'name',
        'openConversationId' => 'openConversationId',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRobotToConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
