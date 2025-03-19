<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartCloudRecordRequest extends Model
{
    /**
     * @example 演讲
     *
     * @var string
     */
    public $mode;

    /**
     * @example 左上
     *
     * @var string
     */
    public $smallWindowPosition;

    /**
     * @description This parameter is required.
     *
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'mode' => 'mode',
        'smallWindowPosition' => 'smallWindowPosition',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->smallWindowPosition) {
            $res['smallWindowPosition'] = $this->smallWindowPosition;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartCloudRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['smallWindowPosition'])) {
            $model->smallWindowPosition = $map['smallWindowPosition'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
