<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncExceedApplyRequest extends Model
{
    /**
     * @description 商旅超标审批单id
     *
     * @var string
     */
    public $applyId;

    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 审批意见
     *
     * @var string
     */
    public $remark;

    /**
     * @description 审批单状态 1同意2拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 第三方流程实例id
     *
     * @var string
     */
    public $thirdpartyFlowId;

    /**
     * @description 用户id
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
