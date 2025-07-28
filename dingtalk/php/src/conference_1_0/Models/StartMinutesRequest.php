<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartMinutesRequest extends Model
{
    /**
     * @example 左上
     *
     * @var string
     */
    public $ownerUnionId;

    /**
     * @example true
     *
     * @var bool
     */
    public $recordAudio;

    /**
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'ownerUnionId' => 'ownerUnionId',
        'recordAudio' => 'recordAudio',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownerUnionId) {
            $res['ownerUnionId'] = $this->ownerUnionId;
        }
        if (null !== $this->recordAudio) {
            $res['recordAudio'] = $this->recordAudio;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartMinutesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ownerUnionId'])) {
            $model->ownerUnionId = $map['ownerUnionId'];
        }
        if (isset($map['recordAudio'])) {
            $model->recordAudio = $map['recordAudio'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
