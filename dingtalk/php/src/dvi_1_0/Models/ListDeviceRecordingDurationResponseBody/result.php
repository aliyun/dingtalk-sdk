<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ListDeviceRecordingDurationResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $duration;

    /**
     * @var int
     */
    public $endTimestamp;

    /**
     * @var string
     */
    public $recordId;

    /**
     * @var string
     */
    public $sn;

    /**
     * @var int
     */
    public $startTimestamp;
    protected $_name = [
        'duration' => 'duration',
        'endTimestamp' => 'endTimestamp',
        'recordId' => 'recordId',
        'sn' => 'sn',
        'startTimestamp' => 'startTimestamp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTimestamp) {
            $res['endTimestamp'] = $this->endTimestamp;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->startTimestamp) {
            $res['startTimestamp'] = $this->startTimestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTimestamp'])) {
            $model->endTimestamp = $map['endTimestamp'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['startTimestamp'])) {
            $model->startTimestamp = $map['startTimestamp'];
        }

        return $model;
    }
}
