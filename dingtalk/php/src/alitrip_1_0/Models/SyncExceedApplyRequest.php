<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncExceedApplyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var string
     */
    public $applyId;

    /**
     * @description This parameter is required.
     *
     * @example ding12345
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 同意
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example asdfg
     *
     * @var string
     */
    public $thirdpartyFlowId;

    /**
     * @description This parameter is required.
     *
     * @example asdfgh
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'applyId'          => 'applyId',
        'corpId'           => 'corpId',
        'remark'           => 'remark',
        'status'           => 'status',
        'thirdpartyFlowId' => 'thirdpartyFlowId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->thirdpartyFlowId) {
            $res['thirdpartyFlowId'] = $this->thirdpartyFlowId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncExceedApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['thirdpartyFlowId'])) {
            $model->thirdpartyFlowId = $map['thirdpartyFlowId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
