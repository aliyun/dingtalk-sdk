<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateRequest\punchParam;
use AlibabaCloud\Tea\Model;

class ProcessApproveCreateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 25c4c49f-cf3a-4ba1-b321-7defd93b7f89
     *
     * @var string
     */
    public $approveId;

    /**
     * @description This parameter is required.
     *
     * @example user02
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @var punchParam
     */
    public $punchParam;

    /**
     * @description This parameter is required.
     *
     * @example shiftGroup
     *
     * @var string
     */
    public $subType;

    /**
     * @description This parameter is required.
     *
     * @example 请假
     *
     * @var string
     */
    public $tagName;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'approveId' => 'approveId',
        'opUserId' => 'opUserId',
        'punchParam' => 'punchParam',
        'subType' => 'subType',
        'tagName' => 'tagName',
        'userId' => 'userId',
    ];

    public function validate() {}

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
