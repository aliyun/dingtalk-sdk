<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAutoIssuePointRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $pointAutoNum;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $pointAutoState;

    /**
     * @description This parameter is required.
     *
     * @example 15
     *
     * @var int
     */
    public $pointAutoTime;

    /**
     * @description This parameter is required.
     *
     * @example 11185568-1380470824
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'pointAutoNum'   => 'pointAutoNum',
        'pointAutoState' => 'pointAutoState',
        'pointAutoTime'  => 'pointAutoTime',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pointAutoNum) {
            $res['pointAutoNum'] = $this->pointAutoNum;
        }
        if (null !== $this->pointAutoState) {
            $res['pointAutoState'] = $this->pointAutoState;
        }
        if (null !== $this->pointAutoTime) {
            $res['pointAutoTime'] = $this->pointAutoTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAutoIssuePointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pointAutoNum'])) {
            $model->pointAutoNum = $map['pointAutoNum'];
        }
        if (isset($map['pointAutoState'])) {
            $model->pointAutoState = $map['pointAutoState'];
        }
        if (isset($map['pointAutoTime'])) {
            $model->pointAutoTime = $map['pointAutoTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
