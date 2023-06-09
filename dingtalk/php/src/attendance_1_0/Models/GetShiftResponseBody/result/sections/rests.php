<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections;

use AlibabaCloud\Tea\Model;

class rests extends Model
{
    /**
     * @var int
     */
    public $across;

    /**
     * @var string
     */
    public $checkTime;

    /**
     * @var string
     */
    public $checkType;

    /**
     * @var int
     */
    public $restId;
    protected $_name = [
        'across'    => 'across',
        'checkTime' => 'checkTime',
        'checkType' => 'checkType',
        'restId'    => 'restId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->across) {
            $res['across'] = $this->across;
        }
        if (null !== $this->checkTime) {
            $res['checkTime'] = $this->checkTime;
        }
        if (null !== $this->checkType) {
            $res['checkType'] = $this->checkType;
        }
        if (null !== $this->restId) {
            $res['restId'] = $this->restId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rests
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['across'])) {
            $model->across = $map['across'];
        }
        if (isset($map['checkTime'])) {
            $model->checkTime = $map['checkTime'];
        }
        if (isset($map['checkType'])) {
            $model->checkType = $map['checkType'];
        }
        if (isset($map['restId'])) {
            $model->restId = $map['restId'];
        }

        return $model;
    }
}
