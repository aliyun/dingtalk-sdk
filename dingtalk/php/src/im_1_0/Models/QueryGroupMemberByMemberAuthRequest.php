<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupMemberByMemberAuthRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example COOLAPP-XXX
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description This parameter is required.
     *
     * @example cidXXX
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'coolAppCode' => 'coolAppCode',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupMemberByMemberAuthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
