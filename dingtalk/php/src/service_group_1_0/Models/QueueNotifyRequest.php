<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueueNotifyRequest extends Model
{
    /**
     * @description 预计等待时间，单位：分钟
     *
     * @var int
     */
    public $estimateWaitMin;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 当前排队次序
     *
     * @var int
     */
    public $queuePlace;

    /**
     * @description 会话id
     *
     * @var string
     */
    public $serviceToken;

    /**
     * @description 渠道类型
     *
     * @var string
     */
    public $targetChannel;

    /**
     * @description 展示文案
     *
     * @var string
     */
    public $tips;

    /**
     * @description DT端定义的访客token
     *
     * @var string
     */
    public $visitorToken;
    protected $_name = [
        'estimateWaitMin' => 'estimateWaitMin',
        'openTeamId'      => 'openTeamId',
        'queuePlace'      => 'queuePlace',
        'serviceToken'    => 'serviceToken',
        'targetChannel'   => 'targetChannel',
        'tips'            => 'tips',
        'visitorToken'    => 'visitorToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->estimateWaitMin) {
            $res['estimateWaitMin'] = $this->estimateWaitMin;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->queuePlace) {
            $res['queuePlace'] = $this->queuePlace;
        }
        if (null !== $this->serviceToken) {
            $res['serviceToken'] = $this->serviceToken;
        }
        if (null !== $this->targetChannel) {
            $res['targetChannel'] = $this->targetChannel;
        }
        if (null !== $this->tips) {
            $res['tips'] = $this->tips;
        }
        if (null !== $this->visitorToken) {
            $res['visitorToken'] = $this->visitorToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueueNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['estimateWaitMin'])) {
            $model->estimateWaitMin = $map['estimateWaitMin'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['queuePlace'])) {
            $model->queuePlace = $map['queuePlace'];
        }
        if (isset($map['serviceToken'])) {
            $model->serviceToken = $map['serviceToken'];
        }
        if (isset($map['targetChannel'])) {
            $model->targetChannel = $map['targetChannel'];
        }
        if (isset($map['tips'])) {
            $model->tips = $map['tips'];
        }
        if (isset($map['visitorToken'])) {
            $model->visitorToken = $map['visitorToken'];
        }

        return $model;
    }
}
