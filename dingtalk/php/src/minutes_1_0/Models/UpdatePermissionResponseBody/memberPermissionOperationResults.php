<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\UpdatePermissionResponseBody;

use AlibabaCloud\Tea\Model;

class memberPermissionOperationResults extends Model
{
    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMessage;

    /**
     * @var int
     */
    public $index;

    /**
     * @var int
     */
    public $memberType;

    /**
     * @var string
     */
    public $memberUnionId;

    /**
     * @var int
     */
    public $opType;

    /**
     * @var int
     */
    public $policyId;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'errorCode' => 'errorCode',
        'errorMessage' => 'errorMessage',
        'index' => 'index',
        'memberType' => 'memberType',
        'memberUnionId' => 'memberUnionId',
        'opType' => 'opType',
        'policyId' => 'policyId',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMessage) {
            $res['errorMessage'] = $this->errorMessage;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->memberType) {
            $res['memberType'] = $this->memberType;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->opType) {
            $res['opType'] = $this->opType;
        }
        if (null !== $this->policyId) {
            $res['policyId'] = $this->policyId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return memberPermissionOperationResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMessage'])) {
            $model->errorMessage = $map['errorMessage'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['memberType'])) {
            $model->memberType = $map['memberType'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['opType'])) {
            $model->opType = $map['opType'];
        }
        if (isset($map['policyId'])) {
            $model->policyId = $map['policyId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
