<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\TopicStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class topicStatisticsRecords extends Model
{
    /**
     * @example 20220101
     *
     * @var string
     */
    public $dt;

    /**
     * @example 20
     *
     * @var int
     */
    public $msgCount;

    /**
     * @example 3
     *
     * @var int
     */
    public $participantsNum;

    /**
     * @example 10
     *
     * @var int
     */
    public $topicNum;
    protected $_name = [
        'dt'              => 'dt',
        'msgCount'        => 'msgCount',
        'participantsNum' => 'participantsNum',
        'topicNum'        => 'topicNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dt) {
            $res['dt'] = $this->dt;
        }
        if (null !== $this->msgCount) {
            $res['msgCount'] = $this->msgCount;
        }
        if (null !== $this->participantsNum) {
            $res['participantsNum'] = $this->participantsNum;
        }
        if (null !== $this->topicNum) {
            $res['topicNum'] = $this->topicNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topicStatisticsRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dt'])) {
            $model->dt = $map['dt'];
        }
        if (isset($map['msgCount'])) {
            $model->msgCount = $map['msgCount'];
        }
        if (isset($map['participantsNum'])) {
            $model->participantsNum = $map['participantsNum'];
        }
        if (isset($map['topicNum'])) {
            $model->topicNum = $map['topicNum'];
        }

        return $model;
    }
}
