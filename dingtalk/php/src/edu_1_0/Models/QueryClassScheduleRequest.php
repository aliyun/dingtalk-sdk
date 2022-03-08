<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryClassScheduleRequest extends Model
{
    /**
     * @description 查询课程的节次。
     *
     * @var int[]
     */
    public $sectionIndexList;

    /**
     * @description 订阅者的Id。
     *
     * @var string[]
     */
    public $subscriberIds;

    /**
     * @description 结束时间（unix时间戳）
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 操作者UserId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 开始时间（unix时间戳）
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 订阅者类型：  DEPARTMENT：班级订阅 USER：老师订阅
     *
     * @var string
     */
    public $subscriberType;
    protected $_name = [
        'sectionIndexList' => 'sectionIndexList',
        'subscriberIds'    => 'subscriberIds',
        'endTime'          => 'endTime',
        'opUserId'         => 'opUserId',
        'startTime'        => 'startTime',
        'subscriberType'   => 'subscriberType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sectionIndexList) {
            $res['sectionIndexList'] = $this->sectionIndexList;
        }
        if (null !== $this->subscriberIds) {
            $res['subscriberIds'] = $this->subscriberIds;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->subscriberType) {
            $res['subscriberType'] = $this->subscriberType;
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
        if (isset($map['sectionIndexList'])) {
            if (!empty($map['sectionIndexList'])) {
                $model->sectionIndexList = $map['sectionIndexList'];
            }
        }
        if (isset($map['subscriberIds'])) {
            if (!empty($map['subscriberIds'])) {
                $model->subscriberIds = $map['subscriberIds'];
            }
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['subscriberType'])) {
            $model->subscriberType = $map['subscriberType'];
        }

        return $model;
    }
}
