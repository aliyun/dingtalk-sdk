<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveApaasAppRequest extends Model
{
    /**
     * @var string
     */
    public $bizAppId;

    /**
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'bizAppId' => 'bizAppId',
        'opUserId' => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveApaasAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
