<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SendMsgByTaskSupportInviteJoinOrgRequest\messageContent;
use AlibabaCloud\Tea\Model;

class SendMsgByTaskSupportInviteJoinOrgRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var messageContent
     */
    public $messageContent;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $mobilePhones;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $needUrlTrack;

    /**
     * @description This parameter is required.
     *
     * @example 88888
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description This parameter is required.
     *
     * @example 发送渠道      * 工作通知：WORK_NOTICE      * 机器人：SINGLE_ROBOT
     *
     * @var string
     */
    public $sendChannel;

    /**
     * @description This parameter is required.
     *
     * @example 群发任务
     *
     * @var string
     */
    public $taskName;
    protected $_name = [
        'messageContent' => 'messageContent',
        'mobilePhones' => 'mobilePhones',
        'needUrlTrack' => 'needUrlTrack',
        'openTeamId' => 'openTeamId',
        'sendChannel' => 'sendChannel',
        'taskName' => 'taskName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageContent) {
            $res['messageContent'] = null !== $this->messageContent ? $this->messageContent->toMap() : null;
        }
        if (null !== $this->mobilePhones) {
            $res['mobilePhones'] = $this->mobilePhones;
        }
        if (null !== $this->needUrlTrack) {
            $res['needUrlTrack'] = $this->needUrlTrack;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->sendChannel) {
            $res['sendChannel'] = $this->sendChannel;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMsgByTaskSupportInviteJoinOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageContent'])) {
            $model->messageContent = messageContent::fromMap($map['messageContent']);
        }
        if (isset($map['mobilePhones'])) {
            if (!empty($map['mobilePhones'])) {
                $model->mobilePhones = $map['mobilePhones'];
            }
        }
        if (isset($map['needUrlTrack'])) {
            $model->needUrlTrack = $map['needUrlTrack'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['sendChannel'])) {
            $model->sendChannel = $map['sendChannel'];
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }

        return $model;
    }
}
