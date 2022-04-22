<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConversationTransferBeginNotifyRequest extends Model
{
    /**
     * @description DT端会话ID
     *
     * @var string
     */
    public $conversationId;

    /**
     * @description 转接备注
     *
     * @var string
     */
    public $memo;

    /**
     * @description 团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 对应外部渠道的会话ID
     *
     * @var string
     */
    public $serviceToken;

    /**
     * @description 原始技能组ID
     *
     * @var string
     */
    public $sourceSkillGroupId;

    /**
     * @description 目标技能组ID
     *
     * @var string
     */
    public $targetSkillGroupId;
    protected $_name = [
        'conversationId'     => 'conversationId',
        'memo'               => 'memo',
        'openTeamId'         => 'openTeamId',
        'serviceToken'       => 'serviceToken',
        'sourceSkillGroupId' => 'sourceSkillGroupId',
        'targetSkillGroupId' => 'targetSkillGroupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->serviceToken) {
            $res['serviceToken'] = $this->serviceToken;
        }
        if (null !== $this->sourceSkillGroupId) {
            $res['sourceSkillGroupId'] = $this->sourceSkillGroupId;
        }
        if (null !== $this->targetSkillGroupId) {
            $res['targetSkillGroupId'] = $this->targetSkillGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConversationTransferBeginNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['serviceToken'])) {
            $model->serviceToken = $map['serviceToken'];
        }
        if (isset($map['sourceSkillGroupId'])) {
            $model->sourceSkillGroupId = $map['sourceSkillGroupId'];
        }
        if (isset($map['targetSkillGroupId'])) {
            $model->targetSkillGroupId = $map['targetSkillGroupId'];
        }

        return $model;
    }
}
