<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryClassScheduleRequest extends Model
{
    /**
     * @description subscriberIds
     *
     * @var string[]
     */
    public $subscriberIds;

    /**
     * @description subscriberType
     *
     * @var string
     */
    public $subscriberType;

    /**
     * @description sectionIndexList
     *
     * @var int[]
     */
    public $sectionIndexList;

    /**
     * @description startTime
     *
     * @var int
     */
    public $startTime;

    /**
     * @description endTime
     *
     * @var int
     */
    public $endTime;

    /**
     * @description opUserId
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'subscriberIds'    => 'subscriberIds',
        'subscriberType'   => 'subscriberType',
        'sectionIndexList' => 'sectionIndexList',
        'startTime'        => 'startTime',
        'endTime'          => 'endTime',
        'opUserId'         => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subscriberIds) {
            $res['subscriberIds'] = $this->subscriberIds;
        }
        if (null !== $this->subscriberType) {
            $res['subscriberType'] = $this->subscriberType;
        }
        if (null !== $this->sectionIndexList) {
            $res['sectionIndexList'] = $this->sectionIndexList;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryClassScheduleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subscriberIds'])) {
            if (!empty($map['subscriberIds'])) {
                $model->subscriberIds = $map['subscriberIds'];
            }
        }
        if (isset($map['subscriberType'])) {
            $model->subscriberType = $map['subscriberType'];
        }
        if (isset($map['sectionIndexList'])) {
            if (!empty($map['sectionIndexList'])) {
                $model->sectionIndexList = $map['sectionIndexList'];
            }
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
