<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseVideoConferenceRequest extends Model
{
    /**
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseVideoConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
