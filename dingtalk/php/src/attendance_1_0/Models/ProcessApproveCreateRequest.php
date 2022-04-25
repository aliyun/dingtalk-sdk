<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateRequest\punchParam;
use AlibabaCloud\Tea\Model;

class ProcessApproveCreateRequest extends Model
{
    /**
     * @description 三方审批单id，全局唯一
     *
     * @var string
     */
    public $approveId;

    /**
     * @description 审批人员工userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 审批单关联的打卡信息
     *
     * @var punchParam
     */
    public $punchParam;

    /**
     * @description 审批单子类型名称：调店:shiftGroup
     *
     * @var string
     */
    public $subType;

    /**
     * @description 审批单类型名称
     *
     * @var string
     */
    public $tagName;

    /**
     * @description 员工的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'approveId'  => 'approveId',
        'opUserId'   => 'opUserId',
        'punchParam' => 'punchParam',
        'subType'    => 'subType',
        'tagName'    => 'tagName',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveId) {
            $res['approveId'] = $this->approveId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->punchParam) {
            $res['punchParam'] = null !== $this->punchParam ? $this->punchParam->toMap() : null;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProcessApproveCreateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveId'])) {
            $model->approveId = $map['approveId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['punchParam'])) {
            $model->punchParam = punchParam::fromMap($map['punchParam']);
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
