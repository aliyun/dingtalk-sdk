<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest\messageContent;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest\queryCustomer;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CustomerSendMsgTaskRequest\sendConfig;
use AlibabaCloud\Tea\Model;

class CustomerSendMsgTaskRequest extends Model
{
    /**
     * @var messageContent
     */
    public $messageContent;

    /**
     * @example 8888
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @var queryCustomer
     */
    public $queryCustomer;

    /**
     * @var sendConfig
     */
    public $sendConfig;

    /**
     * @example 任务名称
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'messageContent' => 'messageContent',
        'openTeamId'     => 'openTeamId',
        'queryCustomer'  => 'queryCustomer',
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
        if (null !== $this->queryCustomer) {
            $res['queryCustomer'] = null !== $this->queryCustomer ? $this->queryCustomer->toMap() : null;
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
     * @return CustomerSendMsgTaskRequest
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
        if (isset($map['queryCustomer'])) {
            $model->queryCustomer = queryCustomer::fromMap($map['queryCustomer']);
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
