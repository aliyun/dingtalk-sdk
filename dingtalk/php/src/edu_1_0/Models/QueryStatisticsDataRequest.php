<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryStatisticsDataRequest extends Model
{
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

    /**
     * @description 课程节次列表
     *
     * @var int[]
     */
    public $sectionIndexList;

    /**
     * @description 老师UserIds
     *
     * @var string[]
     */
    public $teacherUserIds;
    protected $_name = [
        'startTime'        => 'startTime',
        'endTime'          => 'endTime',
        'opUserId'         => 'opUserId',
        'sectionIndexList' => 'sectionIndexList',
        'teacherUserIds'   => 'teacherUserIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->sectionIndexList) {
            $res['sectionIndexList'] = $this->sectionIndexList;
        }
        if (null !== $this->teacherUserIds) {
            $res['teacherUserIds'] = $this->teacherUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryStatisticsDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['sectionIndexList'])) {
            if (!empty($map['sectionIndexList'])) {
                $model->sectionIndexList = $map['sectionIndexList'];
            }
        }
        if (isset($map['teacherUserIds'])) {
            if (!empty($map['teacherUserIds'])) {
                $model->teacherUserIds = $map['teacherUserIds'];
            }
        }

        return $model;
    }
}
