<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAutoIssuePointRequest extends Model
{
    /**
     * @description 企业积分自动发放数量1-10000
     *
     * @var int
     */
    public $pointAutoNum;

    /**
     * @description 企业积分自动发放状态
     *
     * @var bool
     */
    public $pointAutoState;

    /**
     * @description 企业积分自动发放时间 必须为每月的1号或15号，传入1时为1号，传入15时为15号。
     *
     * @var int
     */
    public $pointAutoTime;

    /**
     * @description 操作人userId
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
