<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsRequest\details;
use AlibabaCloud\Tea\Model;

class UpdateShortcutsRequest extends Model
{
    /**
     * @description 配置详情
     *
     * @var details[]
     */
    public $details;

    /**
     * @description 会话id
     *
     * @var string
     */
    public $sessionId;

    /**
     * @description 用户信息
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'details'   => 'details',
        'sessionId' => 'sessionId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->details) {
            $res['details'] = [];
            if (null !== $this->details && \is_array($this->details)) {
                $n = 0;
                foreach ($this->details as $item) {
                    $res['details'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateShortcutsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['details'])) {
            if (!empty($map['details'])) {
                $model->details = [];
                $n              = 0;
                foreach ($map['details'] as $item) {
                    $model->details[$n++] = null !== $item ? details::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
