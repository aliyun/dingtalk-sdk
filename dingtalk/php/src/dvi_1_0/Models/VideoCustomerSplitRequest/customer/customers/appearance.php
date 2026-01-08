<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitRequest\customer\customers;

use AlibabaCloud\Tea\Model;

class appearance extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $videoId;
    protected $_name = [
        'endTime' => 'endTime',
        'startTime' => 'startTime',
        'videoId' => 'videoId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->videoId) {
            $res['videoId'] = $this->videoId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appearance
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['videoId'])) {
            $model->videoId = $map['videoId'];
        }

        return $model;
    }
}
