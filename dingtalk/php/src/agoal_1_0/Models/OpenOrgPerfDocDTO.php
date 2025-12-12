<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenOrgPerfDocDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $docId;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalUserDTO
     */
    public $executor;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $score;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $state;

    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalTeamDTO
     */
    public $team;
    protected $_name = [
        'docId' => 'docId',
        'executor' => 'executor',
        'score' => 'score',
        'state' => 'state',
        'team' => 'team',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->docId) {
            $res['docId'] = $this->docId;
        }
        if (null !== $this->executor) {
            $res['executor'] = null !== $this->executor ? $this->executor->toMap() : null;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->team) {
            $res['team'] = null !== $this->team ? $this->team->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenOrgPerfDocDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docId'])) {
            $model->docId = $map['docId'];
        }
        if (isset($map['executor'])) {
            $model->executor = OpenAgoalUserDTO::fromMap($map['executor']);
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['team'])) {
            $model->team = OpenAgoalTeamDTO::fromMap($map['team']);
        }

        return $model;
    }
}
