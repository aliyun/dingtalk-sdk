<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConversationIdRequest extends Model
{
    /**
     * @description 员工企业账号：staffId#corpId@dingding
     *
     * @var string
     */
    public $userId;

    /**
     * @description 外部用户账号：outerId@channel
     *
     * @var string
     */
    public $appUid;
    protected $_name = [
        'userId' => 'userId',
        'appUid' => 'appUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }

        return $model;
    }
}
