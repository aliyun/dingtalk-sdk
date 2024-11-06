<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumDeleteFormInstanceRequest extends Model
{
    /**
     * @var string[]
     */
    public $formInstanceIds;

    /**
     * @description This parameter is required.
     *
     * @example PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1
     *
     * @var string
     */
    public $processCode;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'formInstanceIds' => 'formInstanceIds',
        'processCode'     => 'processCode',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formInstanceIds) {
            $res['formInstanceIds'] = $this->formInstanceIds;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumDeleteFormInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formInstanceIds'])) {
            if (!empty($map['formInstanceIds'])) {
                $model->formInstanceIds = $map['formInstanceIds'];
            }
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
