<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotMessageRecallRequest extends Model
{
    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开放消息ID
     *
     * @var string
     */
    public $openMsgId;

    /**
     * @description 开发团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openMsgId'          => 'openMsgId',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotMessageRecallRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
