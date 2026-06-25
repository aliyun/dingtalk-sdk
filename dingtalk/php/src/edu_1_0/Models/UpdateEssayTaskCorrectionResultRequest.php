<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateEssayTaskCorrectionResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding123...
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $essayTaskId;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $ext;

    /**
     * @example xxx
     *
     * @var string
     */
    public $failedMsg;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $taskCode;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId' => 'corpId',
        'essayTaskId' => 'essayTaskId',
        'ext' => 'ext',
        'failedMsg' => 'failedMsg',
        'status' => 'status',
        'taskCode' => 'taskCode',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->essayTaskId) {
            $res['essayTaskId'] = $this->essayTaskId;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->failedMsg) {
            $res['failedMsg'] = $this->failedMsg;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateEssayTaskCorrectionResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['essayTaskId'])) {
            $model->essayTaskId = $map['essayTaskId'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['failedMsg'])) {
            $model->failedMsg = $map['failedMsg'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
