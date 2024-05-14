<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateScheduleConferenceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
     *
     * @var string
     */
    public $creatorUnionId;

    /**
     * @description This parameter is required.
     *
     * @example 1687928400000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 1687924800000
     *
     * @var int
     */
    public $startTime;

    /**
     * @description This parameter is required.
     *
     * @example 预约会议标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'creatorUnionId' => 'creatorUnionId',
        'endTime'        => 'endTime',
        'startTime'      => 'startTime',
        'title'          => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateScheduleConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
