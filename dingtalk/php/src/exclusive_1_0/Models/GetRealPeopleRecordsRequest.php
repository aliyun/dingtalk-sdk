<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRealPeopleRecordsRequest extends Model
{
    /**
     * @description 应用唯一标识
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 记录开始时间(毫秒时间戳)
     *
     * @var int
     */
    public $fromTime;

    /**
     * @description 一页最大值（最大50）
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 查询数据的起始位置，0表示从头开始。
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 实人认证结果 1-成功 2-失败
     *
     * @var int
     */
    public $personIdentification;

    /**
     * @description 记录结束时间(毫秒时间戳)
     *
     * @var int
     */
    public $toTime;

    /**
     * @description 员工userIds
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'agentId'              => 'agentId',
        'fromTime'             => 'fromTime',
        'maxResults'           => 'maxResults',
        'nextToken'            => 'nextToken',
        'personIdentification' => 'personIdentification',
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
