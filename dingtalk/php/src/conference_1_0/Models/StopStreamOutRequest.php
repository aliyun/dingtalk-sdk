<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class StopStreamOutRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $stopAllStream;

    /**
     * @description This parameter is required.
     *
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $streamId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'stopAllStream' => 'stopAllStream',
        'streamId' => 'streamId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->stopAllStream) {
            $res['stopAllStream'] = $this->stopAllStream;
        }
        if (null !== $this->streamId) {
            $res['streamId'] = $this->streamId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StopStreamOutRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['stopAllStream'])) {
            $model->stopAllStream = $map['stopAllStream'];
        }
        if (isset($map['streamId'])) {
            $model->streamId = $map['streamId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
