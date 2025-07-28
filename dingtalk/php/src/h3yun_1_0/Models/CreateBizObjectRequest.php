<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBizObjectRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example {\"F0000010\": \"0000004\", \"F0000011\": \"王五1\",\"F0000012\": \"D1级客户\",\"F0000013\": 7000,\"D000183Fcd15f3a51e624bbc9945392d190b6aa8\": [{\"F0000014\": \"里斯\",\"F0000015\": 156666365656, \"F0000016\": \"技术部\",\"F0000017\": \"经理1\",\"F0000018\":\"男\",\"F0000019\": \"lgbxunmi@dd.com\", \"F0000020\": true, \"F0000021\": \"测试数据\"}]}
     *
     * @var string
     */
    public $bizObjectJson;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $isDraft;

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
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectJson' => 'bizObjectJson',
        'isDraft' => 'isDraft',
        'opUserId' => 'opUserId',
        'schemaCode' => 'schemaCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectJson) {
            $res['bizObjectJson'] = $this->bizObjectJson;
        }
        if (null !== $this->isDraft) {
            $res['isDraft'] = $this->isDraft;
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
     * @return CreateBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectJson'])) {
            $model->bizObjectJson = $map['bizObjectJson'];
        }
        if (isset($map['isDraft'])) {
            $model->isDraft = $map['isDraft'];
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
