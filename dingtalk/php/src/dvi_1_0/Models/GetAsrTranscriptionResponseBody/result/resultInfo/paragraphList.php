<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetAsrTranscriptionResponseBody\result\resultInfo;

use AlibabaCloud\Tea\Model;

class paragraphList extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $paragraph;

    /**
     * @var string
     */
    public $speakerId;

    /**
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime' => 'endTime',
        'paragraph' => 'paragraph',
        'speakerId' => 'speakerId',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = $this->paragraph;
        }
        if (null !== $this->speakerId) {
            $res['speakerId'] = $this->speakerId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return paragraphList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = $map['paragraph'];
        }
        if (isset($map['speakerId'])) {
            $model->speakerId = $map['speakerId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
