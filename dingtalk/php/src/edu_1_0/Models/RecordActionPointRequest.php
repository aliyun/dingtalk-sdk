<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class RecordActionPointRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example UPLOAD
     *
     * @var string
     */
    public $actionCode;

    /**
     * @description This parameter is required.
     *
     * @example 1770361351000
     *
     * @var int
     */
    public $actionTime;

    /**
     * @description This parameter is required.
     *
     * @example ding819xxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example DING_xxxxxxxxxx
     *
     * @var string
     */
    public $taskCode;
    protected $_name = [
        'actionCode' => 'actionCode',
        'actionTime' => 'actionTime',
        'corpId' => 'corpId',
        'taskCode' => 'taskCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCode) {
            $res['actionCode'] = $this->actionCode;
        }
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecordActionPointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionCode'])) {
            $model->actionCode = $map['actionCode'];
        }
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }

        return $model;
    }
}
