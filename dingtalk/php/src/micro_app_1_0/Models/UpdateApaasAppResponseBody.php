<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateApaasAppResponseBody extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $agentId;

    /**
     * @var string
     */
    public $bizAppId;
    protected $_name = [
        'agentId'  => 'agentId',
        'bizAppId' => 'bizAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->bizAppId) {
            $res['bizAppId'] = $this->bizAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApaasAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['bizAppId'])) {
            $model->bizAppId = $map['bizAppId'];
        }

        return $model;
    }
}
