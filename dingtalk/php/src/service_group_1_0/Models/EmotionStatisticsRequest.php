<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class EmotionStatisticsRequest extends Model
{
    /**
     * @example 20220101
     *
     * @var string
     */
    public $maxDt;

    /**
     * @example 0.8
     *
     * @var float
     */
    public $maxEmotion;

    /**
     * @example 20220101
     *
     * @var string
     */
    public $minDt;

    /**
     * @example 0
     *
     * @var float
     */
    public $minEmotion;

    /**
     * @example cidXX,cidYY
     *
     * @var string
     */
    public $openConversationIds;

    /**
     * @example ksdfosd
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example KxisoOk
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'maxDt'               => 'maxDt',
        'maxEmotion'          => 'maxEmotion',
        'minDt'               => 'minDt',
        'minEmotion'          => 'minEmotion',
        'openConversationIds' => 'openConversationIds',
        'openGroupSetId'      => 'openGroupSetId',
        'openTeamId'          => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxDt) {
            $res['maxDt'] = $this->maxDt;
        }
        if (null !== $this->maxEmotion) {
            $res['maxEmotion'] = $this->maxEmotion;
        }
        if (null !== $this->minDt) {
            $res['minDt'] = $this->minDt;
        }
        if (null !== $this->minEmotion) {
            $res['minEmotion'] = $this->minEmotion;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EmotionStatisticsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxDt'])) {
            $model->maxDt = $map['maxDt'];
        }
        if (isset($map['maxEmotion'])) {
            $model->maxEmotion = $map['maxEmotion'];
        }
        if (isset($map['minDt'])) {
            $model->minDt = $map['minDt'];
        }
        if (isset($map['minEmotion'])) {
            $model->minEmotion = $map['minEmotion'];
        }
        if (isset($map['openConversationIds'])) {
            $model->openConversationIds = $map['openConversationIds'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
