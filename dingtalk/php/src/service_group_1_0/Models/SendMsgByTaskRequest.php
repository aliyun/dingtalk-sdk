<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\messageContent;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\queryGroup;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskRequest\sendConfig;
use AlibabaCloud\Tea\Model;

class SendMsgByTaskRequest extends Model
{
    /**
     * @description 群发内容
     *
     * @var messageContent
     */
    public $messageContent;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @var queryGroup
     */
    public $queryGroup;

    /**
     * @description 发送配置
     *
     * @var sendConfig
     */
    public $sendConfig;

    /**
     * @description 群发任务名称
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'messageContent' => 'messageContent',
        'openTeamId'     => 'openTeamId',
        'queryGroup'     => 'queryGroup',
        'sendConfig'     => 'sendConfig',
        'taskName'       => 'taskName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageContent) {
            $res['messageContent'] = null !== $this->messageContent ? $this->messageContent->toMap() : null;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->queryGroup) {
            $res['queryGroup'] = null !== $this->queryGroup ? $this->queryGroup->toMap() : null;
        }
        if (null !== $this->sendConfig) {
            $res['sendConfig'] = null !== $this->sendConfig ? $this->sendConfig->toMap() : null;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMsgByTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageContent'])) {
            $model->messageContent = messageContent::fromMap($map['messageContent']);
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['queryGroup'])) {
            $model->queryGroup = queryGroup::fromMap($map['queryGroup']);
        }
        if (isset($map['sendConfig'])) {
            $model->sendConfig = sendConfig::fromMap($map['sendConfig']);
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
