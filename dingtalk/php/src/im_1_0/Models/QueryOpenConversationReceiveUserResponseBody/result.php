<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenConversationReceiveUserResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryOpenConversationReceiveUserResponseBody\result\receiveUser;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var receiveUser
     */
    public $receiveUser;
    protected $_name = [
        'receiveUser' => 'receiveUser',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->receiveUser) {
            $res['receiveUser'] = null !== $this->receiveUser ? $this->receiveUser->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receiveUser'])) {
            $model->receiveUser = receiveUser::fromMap($map['receiveUser']);
        }

        return $model;
    }
}
