<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveApaasAppRequest extends Model
{
    /**
     * @var string
     */
    public $opUserId;

    /**
     * @var string
     */
    public $bizAppId;
    protected $_name = [
        'opUserId' => 'opUserId',
        'bizAppId' => 'bizAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
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
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }

        return $model;
    }
}
