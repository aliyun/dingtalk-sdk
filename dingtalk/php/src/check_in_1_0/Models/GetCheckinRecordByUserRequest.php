<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcheck_in_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCheckinRecordByUserRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'endTime'        => 'endTime',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'operatorUserId' => 'operatorUserId',
        'startTime'      => 'startTime',
        'userIdList'     => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCheckinRecordByUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
