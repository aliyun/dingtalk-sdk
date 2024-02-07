<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwatt_1_0\Models\ConsumePointResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $consumedPoints;
    protected $_name = [
        'consumedPoints' => 'consumedPoints',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->consumedPoints) {
            $res['consumedPoints'] = $this->consumedPoints;
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
        if (isset($map['consumedPoints'])) {
            $model->consumedPoints = $map['consumedPoints'];
        }

        return $model;
    }
}
