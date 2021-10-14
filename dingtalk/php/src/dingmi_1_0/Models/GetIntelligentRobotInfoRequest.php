<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetIntelligentRobotInfoRequest extends Model
{
    /**
     * @description 机器人业务标识
     *
     * @var string
     */
    public $robotAppKey;
    protected $_name = [
        'robotAppKey' => 'robotAppKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotAppKey) {
            $res['robotAppKey'] = $this->robotAppKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetIntelligentRobotInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotAppKey'])) {
            $model->robotAppKey = $map['robotAppKey'];
        }

        return $model;
    }
}
