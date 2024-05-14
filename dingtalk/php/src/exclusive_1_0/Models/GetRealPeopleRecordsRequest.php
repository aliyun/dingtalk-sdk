<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRealPeopleRecordsRequest extends Model
{
    /**
     * @example 123333
     *
     * @var int
     */
    public $agentId;

    /**
     * @example 1667000000
     *
     * @var int
     */
    public $fromTime;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @example 1
     *
     * @var int
     */
    public $personIdentification;

    /**
     * @example 1
     *
     * @var int
     */
    public $scene;

    /**
     * @example 1669000000
     *
     * @var int
     */
    public $toTime;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'agentId'              => 'agentId',
        'fromTime'             => 'fromTime',
        'maxResults'           => 'maxResults',
        'nextToken'            => 'nextToken',
        'personIdentification' => 'personIdentification',
        'scene'                => 'scene',
        'toTime'               => 'toTime',
        'userIds'              => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->fromTime) {
            $res['fromTime'] = $this->fromTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->personIdentification) {
            $res['personIdentification'] = $this->personIdentification;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->toTime) {
            $res['toTime'] = $this->toTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRealPeopleRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['fromTime'])) {
            $model->fromTime = $map['fromTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['personIdentification'])) {
            $model->personIdentification = $map['personIdentification'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['toTime'])) {
            $model->toTime = $map['toTime'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
