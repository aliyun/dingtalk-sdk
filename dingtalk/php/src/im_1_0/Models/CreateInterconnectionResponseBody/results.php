<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\CreateInterconnectionResponseBody;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @description 钉外账号在业务系统内的唯一标识。
     *
     * @var string
     */
    public $appUserId;

    /**
     * @description 失败原因。
     *
     * @var string
     */
    public $message;

    /**
     * @description 该钉外账号被哪个钉内账号负责。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId' => 'appUserId',
        'message'   => 'message',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return results
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
