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
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 群发任务名称
     *
     * @var string
     */
    public $taskName;

    /**
     * @description 群发内容
     *
     * @var messageContent
     */
    public $messageContent;

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
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'openTeamId'         => 'openTeamId',
        'taskName'           => 'taskName',
        'messageContent'     => 'messageContent',
        'queryGroup'         => 'queryGroup',
        'sendConfig'         => 'sendConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->messageContent) {
            $res['messageContent'] = null !== $this->messageContent ? $this->messageContent->toMap() : null;
        }
        if (null !== $this->queryGroup) {
            $res['queryGroup'] = null !== $this->queryGroup ? $this->queryGroup->toMap() : null;
        }
        if (null !== $this->sendConfig) {
            $res['sendConfig'] = null !== $this->sendConfig ? $this->sendConfig->toMap() : null;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['messageContent'])) {
            $model->messageContent = messageContent::fromMap($map['messageContent']);
        }
        if (isset($map['queryGroup'])) {
            $model->queryGroup = queryGroup::fromMap($map['queryGroup']);
        }
        if (isset($map['sendConfig'])) {
            $model->sendConfig = sendConfig::fromMap($map['sendConfig']);
        }

        return $model;
    }
}
