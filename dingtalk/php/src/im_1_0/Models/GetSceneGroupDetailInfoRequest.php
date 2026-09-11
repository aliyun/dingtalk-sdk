<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSceneGroupDetailInfoRequest extends Model
{
    /**
     * @var string
     */
    public $coolAppCode;

    /**
     * @description This parameter is required.
     *
     * @example cidXXXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $permissionCode;
    protected $_name = [
        'coolAppCode' => 'cool_app_code',
        'openConversationId' => 'open_conversation_id',
        'permissionCode' => 'permissionCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['cool_app_code'] = $this->coolAppCode;
        }
        if (null !== $this->openConversationId) {
            $res['open_conversation_id'] = $this->openConversationId;
        }
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSceneGroupDetailInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cool_app_code'])) {
            $model->coolAppCode = $map['cool_app_code'];
        }
        if (isset($map['open_conversation_id'])) {
            $model->openConversationId = $map['open_conversation_id'];
        }
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }

        return $model;
    }
}
