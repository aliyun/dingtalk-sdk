<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConfDataByConferenceIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $realData;
    protected $_name = [
        'realData' => 'realData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->realData) {
            $res['realData'] = $this->realData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConfDataByConferenceIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['realData'])) {
            $model->realData = $map['realData'];
        }

        return $model;
    }
}
