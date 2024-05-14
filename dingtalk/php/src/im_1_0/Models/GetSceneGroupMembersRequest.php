<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSceneGroupMembersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var string
     */
    public $cursor;

    /**
     * @description This parameter is required.
     *
     * @example cidXXXXXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 200
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'coolAppCode'        => 'coolAppCode',
        'cursor'             => 'cursor',
        'openConversationId' => 'openConversationId',
        'size'               => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSceneGroupMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
