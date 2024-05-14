<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateProcessesInstanceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description This parameter is required.
     *
     * @example aea4d7a7-d162-4c77-9c44-7bd9cb8316a5
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example D0001833abb0fb61524487eb01848207bc89b47
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId' => 'bizObjectId',
        'opUserId'    => 'opUserId',
        'schemaCode'  => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateProcessesInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
