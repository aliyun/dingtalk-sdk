<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;

use AlibabaCloud\Tea\Model;

class punchParam extends Model
{
    /**
     * @example 120.023425_30.291465
     *
     * @var string
     */
    public $positionId;

    /**
     * @example 余杭区五常街道
     *
     * @var string
     */
    public $positionName;

    /**
     * @example gps
     *
     * @var string
     */
    public $positionType;

    /**
     * @example 1614222064000
     *
     * @var int
     */
    public $punchTime;
    protected $_name = [
        'positionId' => 'positionId',
        'positionName' => 'positionName',
        'positionType' => 'positionType',
        'punchTime' => 'punchTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->positionId) {
            $res['positionId'] = $this->positionId;
        }
        if (null !== $this->positionName) {
            $res['positionName'] = $this->positionName;
        }
        if (null !== $this->positionType) {
            $res['positionType'] = $this->positionType;
        }
        if (null !== $this->punchTime) {
            $res['punchTime'] = $this->punchTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return punchParam
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['positionId'])) {
            $model->positionId = $map['positionId'];
        }
        if (isset($map['positionName'])) {
            $model->positionName = $map['positionName'];
        }
        if (isset($map['positionType'])) {
            $model->positionType = $map['positionType'];
        }
        if (isset($map['punchTime'])) {
            $model->punchTime = $map['punchTime'];
        }

        return $model;
    }
}
