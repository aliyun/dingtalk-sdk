<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationIdRequest extends Model
{
    /**
     * @var string
     */
    public $appUid;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUid' => 'appUid',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConversationIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
