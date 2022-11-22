<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCallBackFaileResultRequest extends Model
{
    /**
     * @description 大于等于时间戳
     *
     * @var int
     */
    public $beginTime;

    /**
     * @description 小于等于时间戳
     *
     * @var int
     */
    public $endTime;
    protected $_name = [
        'beginTime' => 'beginTime',
        'endTime'   => 'endTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->beginTime) {
            $res['beginTime'] = $this->beginTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCallBackFaileResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['beginTime'])) {
            $model->beginTime = $map['beginTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }

        return $model;
    }
}
