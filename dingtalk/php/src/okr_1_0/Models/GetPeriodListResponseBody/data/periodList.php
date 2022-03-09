<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\GetPeriodListResponseBody\data;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class periodList extends Model
{
    /**
     * @var float
     */
    public $endTime;

    /**
     * @var Stream
     */
    public $id;

    /**
     * @var bool
     */
    public $isCurrent;

    /**
     * @var bool
     */
    public $isYearly;

    /**
     * @var Stream
     */
    public $name;

    /**
     * @var float
     */
    public $startTime;
    protected $_name = [
        'endTime'   => 'endTime',
        'id'        => 'id',
        'isCurrent' => 'isCurrent',
        'isYearly'  => 'isYearly',
        'name'      => 'name',
        'startTime' => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isCurrent) {
            $res['isCurrent'] = $this->isCurrent;
        }
        if (null !== $this->isYearly) {
            $res['isYearly'] = $this->isYearly;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return periodList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isCurrent'])) {
            $model->isCurrent = $map['isCurrent'];
        }
        if (isset($map['isYearly'])) {
            $model->isYearly = $map['isYearly'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
