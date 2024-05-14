<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListPunchScheduleByConditionWithPagingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2aa6736c715944329xxxxxxxxd38be41
     *
     * @var string
     */
    public $bizInstanceId;

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
     * @var int
     */
    public $nextToken;

    /**
     * @example 2022-03-13
     *
     * @var string
     */
    public $scheduleDateEnd;

    /**
     * @example 2022-03-13
     *
     * @var string
     */
    public $scheduleDateStart;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'bizInstanceId'     => 'bizInstanceId',
        'maxResults'        => 'maxResults',
        'nextToken'         => 'nextToken',
        'scheduleDateEnd'   => 'scheduleDateEnd',
        'scheduleDateStart' => 'scheduleDateStart',
        'userIdList'        => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizInstanceId) {
            $res['bizInstanceId'] = $this->bizInstanceId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->scheduleDateEnd) {
            $res['scheduleDateEnd'] = $this->scheduleDateEnd;
        }
        if (null !== $this->scheduleDateStart) {
            $res['scheduleDateStart'] = $this->scheduleDateStart;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPunchScheduleByConditionWithPagingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizInstanceId'])) {
            $model->bizInstanceId = $map['bizInstanceId'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['scheduleDateEnd'])) {
            $model->scheduleDateEnd = $map['scheduleDateEnd'];
        }
        if (isset($map['scheduleDateStart'])) {
            $model->scheduleDateStart = $map['scheduleDateStart'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
