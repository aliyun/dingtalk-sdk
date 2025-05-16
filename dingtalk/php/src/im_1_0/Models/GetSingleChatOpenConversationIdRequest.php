<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSingleChatOpenConversationIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 022*****2134
     *
     * @var string
     */
    public $userId1;

    /**
     * @description This parameter is required.
     *
     * @example 072*****1243
     *
     * @var string
     */
    public $userId2;
    protected $_name = [
        'userId1' => 'userId1',
        'userId2' => 'userId2',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId1) {
            $res['userId1'] = $this->userId1;
        }
        if (null !== $this->userId2) {
            $res['userId2'] = $this->userId2;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSingleChatOpenConversationIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId1'])) {
            $model->userId1 = $map['userId1'];
        }
        if (isset($map['userId2'])) {
            $model->userId2 = $map['userId2'];
        }

        return $model;
    }
}
