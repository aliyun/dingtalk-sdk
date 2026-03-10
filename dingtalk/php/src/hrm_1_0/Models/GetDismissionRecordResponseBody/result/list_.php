<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetDismissionRecordResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $lastWorkDay;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'lastWorkDay' => 'lastWorkDay',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastWorkDay) {
            $res['lastWorkDay'] = $this->lastWorkDay;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lastWorkDay'])) {
            $model->lastWorkDay = $map['lastWorkDay'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
